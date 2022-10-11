namespace Library.Models
{
    using Library.Repository;
    using Newtonsoft.Json;
    using System;

    public class Player
    {
        private static RepositoryFactory rp = new RepositoryFactory();
        private static IRepository repo = rp.GiveThisManARepository();
        private static IList<Match> matches = GetMatches();

        private static IList<Match> GetMatches()
        {
            var matches = new List<Match>();
            matches = (List<Match>)repo.GetMatches(Cup.Male);
            foreach (var item in repo.GetMatches(Cup.Female))
            {
                matches.Add(item);
            }
            return matches;
        }
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("captain")]
        public bool Captain { get; set; }

        [JsonProperty("shirt_number")]
        public long ShirtNumber { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }
        public override string ToString()
        {
            return $"{ShirtNumber}: {Name}";
        }
        [JsonProperty("goal_number")]
        public int GoalNumber => GetGoalNumber();

        private int GetGoalNumber()
        {
            int temp = 0;

            foreach (var item in matches)
            {
                item.HomeTeamEvents.ForEach(i =>
                {
                    if (i.TypeOfEvent == "goal" && i.Player == $"{this.Name}")
                    {
                        temp++;
                    }
                    ;
                });
                item.AwayTeamEvents.ForEach(i =>
                {
                    if (i.TypeOfEvent == "goal" && i.Player == $"{this.Name}")
                    {
                        temp++;
                    }
                    ;
                });

            }

            return temp;
        }

        [JsonProperty("yellow_card_number")]
        public int YellowCardNumber => GetYellowCardNumber();

        private int GetYellowCardNumber()
        {

            int temp = 0;

            foreach (var item in matches)
            {
                item.HomeTeamEvents.ForEach(i =>
                {
                    if (i.TypeOfEvent == "yellow-card" && i.Player == $"{this.Name}")
                    {
                        temp++;
                    };


                });
                item.AwayTeamEvents.ForEach(i =>
                {
                    if (i.TypeOfEvent == "yellow-card" && i.Player == $"{this.Name}")
                    {
                        temp++;
                    };


                });

            }

            return temp;
        }
    }
}
