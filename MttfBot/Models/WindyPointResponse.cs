using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MttfBot.Models
{
    [Serializable]
    public class WindyPointResponse
    {
        [JsonProperty("ts")]
        public long[] Ts { get; set; }

        [JsonProperty("units")]
        public JProperty Units { get; set; }

        [JsonProperty("wind_u-surface")]
        public double[] WindU_Surface { get; set; }

        [JsonProperty("wind_v-surface")]
        public double[] WindV_Surface { get; set; }

        [JsonProperty("dewpoint-surface")]
        public double[] Dewpoint_Surface { get; set; }

        [JsonProperty("rh-surface")]
        public double[] Rh_Surface { get; set; }

        [JsonProperty("pressure-surface")]
        public double[] Pressure_Surface { get; set; }
    }
}
