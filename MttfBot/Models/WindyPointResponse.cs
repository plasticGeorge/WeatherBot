using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MttfBot.Models
{
    [Serializable]
    public class WindyPointResponse
    {
        [JsonPropertyName("ts")]
        public long[] Ts { get; set; }

        [JsonPropertyName("units")]
        public Dictionary<string, string> Units { get; set; }

        [JsonPropertyName("wind_u-surface")]
        public double[] WindU_Surface { get; set; }

        [JsonPropertyName("wind_v-surface")]
        public double[] WindV_Surface { get; set; }

        [JsonPropertyName("dewpoint-surface")]
        public double[] Dewpoint_Surface { get; set; }

        [JsonPropertyName("rh-surface")]
        public double[] Rh_Surface { get; set; }

        [JsonPropertyName("pressure-surface")]
        public double[] Pressure_Surface { get; set; }
    }
}
