using Newtonsoft.Json;
using System;

namespace RandomUserSharp.Models
{
    public class Login
    {
        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("md5")]
        public string Md5 { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }

        [JsonProperty("sha256")]
        public string Sha256 { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("uuid")]
        public Guid Uuid { get; set; }
    }
}