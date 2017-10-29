using Newtonsoft.Json;

namespace RandomUserSharp.Models
{
    public class Picture
    {
        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
    }
}