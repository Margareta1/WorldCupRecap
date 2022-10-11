namespace Library.Repository
{
    using Library.Models;
    using System.Drawing;

    public class FileRepository : IRepository
    {
        private const string SETTINGS_DIR = @"C:\Users\38597\Desktop\dotnet\Library\Configuration\Config.txt";
        private const string IMAGES_DIR = @"C:\Users\38597\Desktop\dotnet\Library\Images\";
        private const string DEFAULT_IMAGE_DIR = @"C:\Users\38597\Desktop\dotnet\Library\Images\default.jpg";
        private const string MEN_DIR = @"C:\Users\38597\Desktop\dotnet\Library\Data\men\";
        private const string WOMEN_DIR = @"C:\Users\38597\Desktop\dotnet\Library\Data\women\";
        //problem with relative paths?

        public Image GetImage(string imgPath)
        {
            return Image.FromFile(imgPath);
        }

        public Image GetImageForPlayer(string playerName)
        {
            try
            {
                return Image.FromFile(IMAGES_DIR + playerName + ".png");
            }
            catch (Exception)
            {
                return Image.FromFile(DEFAULT_IMAGE_DIR);
            }
        }

        public IList<Match> GetMatches(Cup cup)
        {
            return Match.FromJson(File.ReadAllText((cup == Cup.Male ? MEN_DIR : WOMEN_DIR) + "matches.json")) as IList<Match>;

        }

        public IList<Team> GetMensTeams()
        {

            return Team.FromJson(File.ReadAllText(MEN_DIR + "teams.json"));

        }

        public IList<Player> GetPlayersForTeam(Cup cup, int id)
        {
            IList<Player> players = new List<Player>();
            IList<Match> matches = new List<Match>();
            Match m = new Match();
            IList<Team> teams = new List<Team>();
            Team t = new Team();
            if (cup == Cup.Male)
            {
                teams = GetMensTeams();
            }
            else
            {
                teams = GetWomensTeams();
            }
            t = teams.FirstOrDefault(m => m.Id == id);
            matches = GetMatches(cup);
            m = matches.FirstOrDefault(k => k.HomeTeam.Code == t.FifaCode);
            players = m.HomeTeamStatistics.StartingEleven;
            //players.Union(m.HomeTeamStatistics.Substitutes);
            foreach (var k in m.HomeTeamStatistics.Substitutes)
            {
                players.Add(k);
            }
            return players;

        }

        public IList<GroupResult> GetResultsForGroup(int idGroup, Cup cup)
        {

            return GroupResult.FromJson(File.ReadAllText((cup == Cup.Male ? MEN_DIR : WOMEN_DIR) + "group_results.json"));

        }

        public IList<TeamResult> GetResultsForTeam(int idTeam, Cup cup)
        {

            return TeamResult.FromJson(File.ReadAllText((cup == Cup.Male ? MEN_DIR : WOMEN_DIR) + "results.json"));

        }

        public Settings GetSettings()
        {
            Settings s = new Settings();

            using (StreamReader reader = new StreamReader(SETTINGS_DIR))
            {

                s.CupChoice = reader.ReadLine().Trim() == "Female" ? Cup.Female : Cup.Male;
                s.LanguageChoice = reader.ReadLine().Trim() == "Croatian" ? Language.Croatian : Language.English;
                IList<Team> temp = new List<Team>();
                if (s.CupChoice == Cup.Female)
                {
                    temp = GetWomensTeams();
                }
                else
                {
                    temp = GetMensTeams();
                }
                s.FavoritePlayers = new List<Player>();
                int i = int.Parse(reader.ReadLine().Trim());
                foreach (var item in temp)
                {
                    if (item.Id == i)
                    {
                        s.FavoriteTeam = item;
                    }
                }
                List<string> pl = new List<string>();
                pl.Add(reader.ReadLine());
                pl.Add(reader.ReadLine());
                pl.Add(reader.ReadLine());
                IList<Match> m = GetMatches(s.CupChoice);
                Match match = m.FirstOrDefault(m => m.HomeTeam.Country == s.FavoriteTeam.Country);
                IList<Player> players = (IList<Player>)match.HomeTeamStatistics.StartingEleven;
                foreach (var item in match.HomeTeamStatistics.Substitutes)
                {
                    players.Add(item);
                }

                foreach (var item in pl)
                {
                    foreach (var it in players)
                    {
                        if (item == it.Name)
                        {
                            s.FavoritePlayers.Add(it);
                        }
                    }
                }

            }
            return s;
        }

        public IList<Team> GetWomensTeams()
        {
            return Team.FromJson(File.ReadAllText(WOMEN_DIR + "teams.json"));
        }

        public bool HasSettings()
        {
            try
            {
                Settings a = GetSettings();

            }
            catch (Exception e)
            {

                return false;
            }
            return true;
        }

        public void SetImageForPlayer(string playerName, Image image)
        {

            if (File.Exists(IMAGES_DIR + playerName + ".png"))
            {
                File.Delete(IMAGES_DIR + playerName + ".png");
            }
            image.Save(IMAGES_DIR + playerName + ".png", System.Drawing.Imaging.ImageFormat.Png);

        }

        public void SetSettings(Settings settings)
        {
            using (StreamWriter writer = new StreamWriter(SETTINGS_DIR))
            {
                writer.WriteLine(settings.CupChoice);
                writer.WriteLine(settings.LanguageChoice);
                writer.WriteLine(settings.FavoriteTeam.Id);
                writer.WriteLine(settings.FavoritePlayers[0].Name);
                writer.WriteLine(settings.FavoritePlayers[1].Name);
                writer.WriteLine(settings.FavoritePlayers[2].Name);
            }
        }

    }
}
