using Newtonsoft.Json;
using System;

namespace MttfBot.Models
{
    [Serializable]
    public class WindyPointRequest
    {
        [JsonProperty("lat")]
        public double Latitude { get; set; }

        [JsonProperty("lon")]
        public double Longitude { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("parameters")]
        public string[] Parameters { get; set; }

        [JsonProperty("levels")]
        public string[] Levels { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }
}
