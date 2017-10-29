using Newtonsoft.Json;

namespace RandomUserSharp.Models
{
    public class Location
    {
        [JsonProperty("postcode")]
        public long Postcode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }
    }
}