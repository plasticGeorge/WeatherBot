using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MttfBot.Models
{
    [Serializable]
    public class WindyPointResponse
    {
        [JsonPropertyName("ts")]
        public long[] Timestamp { get; set; }

        [JsonPropertyName("units")]
        public Dictionary<string, string> Units { get; set; }

        [JsonPropertyName("wind_u-surface")]
        public double[] WindUSurface { get; set; }

        [JsonPropertyName("wind_v-surface")]
        public double[] WindVSurface { get; set; }

        [JsonPropertyName("dewpoint-surface")]
        public double[] DewpointSurface { get; set; }

        [JsonPropertyName("rh-surface")]
        public double[] RhSurface { get; set; }

        [JsonPropertyName("pressure-surface")]
        public double[] PressureSurface { get; set; }
    }
}
