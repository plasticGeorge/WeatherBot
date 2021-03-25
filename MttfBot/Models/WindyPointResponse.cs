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
        public int[] Ts { get; set; }

        public JObject Units { get; set; }
    }
}
