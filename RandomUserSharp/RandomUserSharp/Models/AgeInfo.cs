using System;
using Newtonsoft.Json;

namespace RandomUserSharp.Models
{
    public class AgeInfo
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        
        [JsonProperty("age")]
        public int Age { get; set; }
    }
}
