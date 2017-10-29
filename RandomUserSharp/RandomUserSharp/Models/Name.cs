using Newtonsoft.Json;

namespace RandomUserSharp.Models
{
    public class Name
    {
        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}