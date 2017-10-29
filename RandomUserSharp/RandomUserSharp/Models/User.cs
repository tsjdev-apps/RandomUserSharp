using Newtonsoft.Json;

namespace RandomUserSharp.Models
{
    public class User
    {
        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("dob")]
        public string Dob { get; set; }

        [JsonProperty("cell")]
        public string Cell { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("id")]
        public Id Id { get; set; }

        [JsonProperty("login")]
        public Login Login { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("nat")]
        public string Nat { get; set; }

        [JsonProperty("picture")]
        public Picture Picture { get; set; }

        [JsonProperty("registered")]
        public string Registered { get; set; }
    }
}