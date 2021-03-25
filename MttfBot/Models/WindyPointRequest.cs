using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        public string Model { get; set; } = "gfs";

        [JsonProperty("parameters")]
        public string[] Parameters { get; set; } = new string[] { "temp", "wind", "precip", "convPrecip", "snowPrecip", "pressure" };

        [JsonProperty("levels")]
        public string[] Levels { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }
}
