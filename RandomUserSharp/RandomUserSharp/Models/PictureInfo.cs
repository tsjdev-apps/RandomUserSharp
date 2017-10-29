using System;
using Newtonsoft.Json;
using RandomUserSharp.Utils;

namespace RandomUserSharp.Models
{
    public class PictureInfo
    {
        [JsonProperty("medium")]
        [JsonConverter(typeof(UriConverter))]
        public Uri Medium { get; set; }

        [JsonProperty("large")]
        [JsonConverter(typeof(UriConverter))]
        public Uri Large { get; set; }

        [JsonProperty("thumbnail")]
        [JsonConverter(typeof(UriConverter))]
        public Uri Thumbnail { get; set; }
    }
}