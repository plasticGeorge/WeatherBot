using System;
using System.Text.Json.Serialization;

namespace MttfBot.Models
{
    [Serializable]
    public class WindyPointRequest
    {
        [JsonPropertyName("lat")]
        public double Latitude { get; set; }

        [JsonPropertyName("lon")]
        public double Longitude { get; set; }

        [JsonPropertyName("model")]
        public string Model { get; set; }

        [JsonPropertyName("parameters")]
        public string[] Parameters { get; set; }

        [JsonPropertyName("levels")]
        public string[] Levels { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }
    }
}
