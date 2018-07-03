using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RandomUserSharp.Models
{
    public class User
    {
        [JsonProperty("gender")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Gender Gender { get; set; }

        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("dob")]
        public AgeInfo DateOfBirth { get; set; }

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
        [JsonConverter(typeof(StringEnumConverter))]
        public Nationality Nationality { get; set; }

        [JsonProperty("picture")]
        public PictureInfo PictureInfo { get; set; }

        [JsonProperty("registered")]
        public AgeInfo Registered { get; set; }
    }
}