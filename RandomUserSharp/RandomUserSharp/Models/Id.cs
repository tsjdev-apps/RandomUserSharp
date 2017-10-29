using Newtonsoft.Json;

namespace RandomUserSharp.Models
{
    public class Id
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}