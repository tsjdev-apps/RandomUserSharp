using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RandomUserSharp.Utils
{
    public class UnixDateTimeConverter : DateTimeConverterBase
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            double timestamp;
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    timestamp = Convert.ToInt64(reader.Value);
                    break;
                case JsonToken.String:
                    timestamp = double.Parse(reader.Value.ToString());
                    break;
                default:
                    throw new NotSupportedException("Invalid token type");
            }

            var startDateTime = new DateTime(1970, 1, 1);
            return startDateTime.AddSeconds(timestamp);
        }
    }
}
