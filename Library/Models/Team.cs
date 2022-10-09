namespace Library.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public partial class Team
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("alternate_name")]
        public object AlternateName { get; set; }

        [JsonProperty("fifa_code")]
        public string FifaCode { get; set; }

        [JsonProperty("group_id")]
        public long GroupId { get; set; }

        [JsonProperty("group_letter")]
        public string GroupLetter { get; set; }
        public override string ToString()
        {
            return $"{Id}: {FifaCode}";
        }
    }

    public partial class Team
    {
        public static List<Team> FromJson(string json) => JsonConvert.DeserializeObject<List<Team>>(json);
    }


    
}
