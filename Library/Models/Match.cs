namespace Library.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public partial class Match
    {
        [JsonProperty("venue")]
        public string Venue { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("fifa_id")]
        public long FifaId { get; set; }

        [JsonProperty("weather")]
        public Weather Weather { get; set; }

        [JsonProperty("attendance")]
        public long Attendance { get; set; }

        [JsonProperty("officials")]
        public List<string> Officials { get; set; }

        [JsonProperty("stage_name")]
        public string StageName { get; set; }

        [JsonProperty("home_team_country")]
        public string HomeTeamCountry { get; set; }

        [JsonProperty("away_team_country")]
        public string AwayTeamCountry { get; set; }

        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("winner")]
        public string Winner { get; set; }

        [JsonProperty("winner_code")]
        public string WinnerCode { get; set; }

        [JsonProperty("home_team")]
        public MatchTeam HomeTeam { get; set; }

        [JsonProperty("away_team")]
        public MatchTeam AwayTeam { get; set; }

        [JsonProperty("home_team_events")]
        public List<TeamEvent> HomeTeamEvents { get; set; }

        [JsonProperty("away_team_events")]
        public List<TeamEvent> AwayTeamEvents { get; set; }

        [JsonProperty("home_team_statistics")]
        public TeamStatistics? HomeTeamStatistics { get; set; }

        [JsonProperty("away_team_statistics")]
        public TeamStatistics? AwayTeamStatistics { get; set; }

        [JsonProperty("last_event_update_at")]
        public string LastEventUpdateAt { get; set; }

        [JsonProperty("last_score_update_at")]
        public string LastScoreUpdateAt { get; set; }

    }

    public partial class Match
    {
        public static List<Match> FromJson(string json) => JsonConvert.DeserializeObject<List<Match>>(json);

    }
    public class MatchTeam
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("goals")]
        public int Goals { get; set; }

        [JsonProperty("penalties")]
        public int Penalties { get; set; }

    }
    public partial class TeamEvent
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("type_of_event")]
        public string TypeOfEvent { get; set; }

        [JsonProperty("player")]
        public string Player { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
    }

    public partial class TeamStatistics
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("attempts_on_goal")]
        public int? AttemptsOnGoal { get; set; }

        [JsonProperty("on_target")]
        public int? OnTarget { get; set; }

        [JsonProperty("off_target")]
        public int? OffTarget { get; set; }

        [JsonProperty("blocked")]
        public int? Blocked { get; set; }

        [JsonProperty("woodwork")]
        public int? Woodwork { get; set; }

        [JsonProperty("corners")]
        public int? Corners { get; set; }

        [JsonProperty("offsides")]
        public int? Offsides { get; set; }

        [JsonProperty("ball_possession")]
        public int? BallPossession { get; set; }

        [JsonProperty("pass_accuracy")]
        public int? PassAccuracy { get; set; }

        [JsonProperty("num_passes")]
        public int? NumPasses { get; set; }

        [JsonProperty("passes_completed")]
        public int? PassesCompleted { get; set; }

        [JsonProperty("distance_covered")]
        public int? DistanceCovered { get; set; }

        [JsonProperty("balls_recovered")]
        public int? BallsRecovered { get; set; }

        [JsonProperty("tackles")]
        public int? Tackles { get; set; }

        [JsonProperty("clearances")]
        public int? Clearances { get; set; }

        [JsonProperty("yellow_cards")]
        public int? YellowCards { get; set; }

        [JsonProperty("red_cards")]
        public int? RedCards { get; set; }

        [JsonProperty("fouls_committed")]
        public int? FoulsCommitted { get; set; }

        [JsonProperty("tactics")]
        public string Tactics { get; set; }

        [JsonProperty("starting_eleven")]
        public IList<Player> StartingEleven { get; set; }

        [JsonProperty("substitutes")]
        public IList<Player> Substitutes { get; set; }
    }

    public partial class Weather
    {
        [JsonProperty("humidity")]
        public long Humidity { get; set; }

        [JsonProperty("temp_celsius")]
        public long TempCelsius { get; set; }

        [JsonProperty("temp_farenheit")]
        public long TempFarenheit { get; set; }

        [JsonProperty("wind_speed")]
        public long WindSpeed { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

}
