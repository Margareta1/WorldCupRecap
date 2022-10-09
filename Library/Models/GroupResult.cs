namespace Library.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public partial class GroupResult
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("letter")]
        public string Letter { get; set; }

        [JsonProperty("ordered_teams")]
        public List<TeamResult> OrderedTeamResults { get; set; }
    }

    public partial class GroupResult
    {
        public static List<GroupResult> FromJson(string json) => JsonConvert.DeserializeObject<List<GroupResult>>(json);
    }

}
