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
        public Dictionary<string, string> Units { get; set; }

        [JsonProperty("wind_u-surface")]
        public decimal[] WindU_Surface { get; set; }

        [JsonProperty("wind_v-surface")]
        public decimal[] WindV_Surface { get; set; }

        [JsonProperty("dewpoint-surface")]
        public decimal[] Dewpoint_Surface { get; set; }

        [JsonProperty("rh-surface")]
        public decimal[] Rh_Surface { get; set; }

        [JsonProperty("pressure-surface")]
        public decimal[] Pressure_Surface { get; set; }
    }
}
