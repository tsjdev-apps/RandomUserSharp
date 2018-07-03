using Newtonsoft.Json;

namespace RandomUserSharp.Models
{
    public class Location
    {
        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("coordinates")]
        public Coordinates Coordinates { get; set; }
        
        [JsonProperty("timezonme")]
        public Timezone Timezone { get; set; }
    }
}