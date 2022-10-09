namespace Library.Models
{
    using Newtonsoft.Json;
    public class Player
    {
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
    }
}
