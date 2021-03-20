using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MttfBot.Models
{
    [Serializable]
    [JsonObject]
    public class ClientInfo
    {
        [JsonProperty("button_actions")]
        public string[] ButtonActions { get; set; }

        [JsonProperty("keyboard")]
        public bool Keyboard { get; set; }

        [JsonProperty("inline_keyboard")]
        public bool InlineKeyboard { get; set; }

        [JsonProperty("carousel")]
        public bool Carousel { get; set; }

        [JsonProperty("lang_id")]
        public int LangId { get; set; }
    }
}
