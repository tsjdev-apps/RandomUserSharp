using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RandomUserSharp.Utils;

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
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime DateOfBirth { get; set; }

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
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Registered { get; set; }
    }
}