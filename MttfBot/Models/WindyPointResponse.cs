using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MttfBot.Models
{
    [Serializable]
    public class WindyPointResponse
    {
        [JsonProperty("ts")]
        public long[] Timestamp { get; set; }

        [JsonProperty("units")]
        public Dictionary<string, string> Units { get; set; }

        [JsonProperty("wind_u-surface")]
        public double[] WindUSurface { get; set; }

        [JsonProperty("wind_v-surface")]
        public double[] WindVSurface { get; set; }

        [JsonProperty("dewpoint-surface")]
        public double[] DewpointSurface { get; set; }

        [JsonProperty("rh-surface")]
        public double[] RhSurface { get; set; }

        [JsonProperty("pressure-surface")]
        public double[] PressureSurface { get; set; }
    }
}
