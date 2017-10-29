using System.Collections.Generic;
using Newtonsoft.Json;

namespace RandomUserSharp.Models
{
    public class RootObject
    {
        [JsonProperty("info")]
        public Info Info { get; set; }

        [JsonProperty("results")]
        public List<User> Users { get; set; }
    }
}
