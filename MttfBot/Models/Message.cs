using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MttfBot.Models
{
    [Serializable]
    [JsonObject]
    public class Message
    {
        [JsonProperty("date")]
        public int Date { get; set; }

        [JsonProperty("from_id")]
        public int FromId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("out")]
        public long Out { get; set; }

        [JsonProperty("peer_id")]
        public int PeerId { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("conversation_message_id")]
        public int ConversationMessageId { get; set; }

        //[JsonProperty("fwd_messages")]
        //

        [JsonProperty("important")]
        public bool Important { get; set; }

        [JsonProperty("random_id")]
        public int RandomId { get; set; }

        //[JsonProperty("attachments")]
        //public JObject[] Attachments { get; set; }

        [JsonProperty("is_hidden")]
        public bool IsHidden { get; set; }
    }
}
