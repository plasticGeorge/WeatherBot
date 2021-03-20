using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MttfBot.Models
{
    [Serializable]
    [JsonObject]
    public class VkObject
    {
        [JsonProperty("message")]
        public Message Message { get; set; }

        [JsonProperty("client_info")]
        public ClientInfo ClientInfo { get; set; }
    }
}
