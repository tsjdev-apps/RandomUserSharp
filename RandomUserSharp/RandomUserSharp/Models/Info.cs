using Newtonsoft.Json;

namespace RandomUserSharp.Models
{
    public class Info
    {
        [JsonProperty("results")]
        public long Results { get; set; }

        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("seed")]
        public string Seed { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}