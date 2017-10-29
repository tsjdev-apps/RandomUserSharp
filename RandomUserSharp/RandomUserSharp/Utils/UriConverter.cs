using System;
using Newtonsoft.Json;

namespace RandomUserSharp.Utils
{
    internal class UriConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return Uri.TryCreate(reader.Value.ToString(), UriKind.Absolute, out var uri) ? uri : null;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Uri);
        }
    }
}
