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
	public class Callback
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("object")]
		public VkObject Object { get; set; }

		[JsonProperty("group_id")]
		public long GroupId { get; set; }

		[JsonProperty("event_id")]
		public string EventID { get; set; }

		[JsonProperty("secret")]
		public string Secret { get; set; }

        public override string ToString()
        {
			return
			$"type: {this?.Type}\n" +
			$"object:\n" +
			$"\tmessage:\n" +
			$"\t\tdate: {this.Object?.Message?.Date}" +
			$"\t\tfrom_id: {this.Object?.Message?.FromId}" +
			$"\t\tid: {this.Object?.Message?.Id}" +
			$"\t\tout: {this.Object?.Message?.Out}" +
			$"\t\tpeer_id: {this.Object?.Message?.PeerId}" +
			$"\t\ttext: {this.Object?.Message?.Text}" +
			$"\t\tconversation_message_id: {this.Object?.Message?.ConversationMessageId}" +
			$"\t\tfwd_messages: -" +
			$"\t\timportant: {this.Object?.Message?.Important}" +
			$"\t\trandom_id: {this.Object?.Message?.RandomId}" +
			$"\t\tattachments: -" +
			$"\t\tis_hidden: {this.Object?.Message?.IsHidden}" +
			$"\tclient_info:" +
			$"\t\tbutton_actions: [" +
			$"\t\t\t{this.Object?.ClientInfo?.ButtonActions[0]}" +
			$"\t\t\t{this.Object?.ClientInfo?.ButtonActions[1]}" +
			$"\t\t\t{this.Object?.ClientInfo?.ButtonActions[2]}" +
			$"\t\t\t{this.Object?.ClientInfo?.ButtonActions[3]}" +
			$"\t\t\t{this.Object?.ClientInfo?.ButtonActions[4]}" +
			$"\t\t\t{this.Object?.ClientInfo?.ButtonActions[5]}" +
			$"\t\t\t{this.Object?.ClientInfo?.ButtonActions[6]}" +
			$"\t\t\t{this.Object?.ClientInfo?.ButtonActions[7]}" +
			$"\t\t\t]" +
			$"\t\tkeyboard: {this.Object?.ClientInfo?.Keyboard}" +
			$"\t\tinline_keyboard: {this.Object?.ClientInfo?.InlineKeyboard}" +
			$"\t\tcarousel: {this.Object?.ClientInfo?.Carousel}" +
			$"\t\tlang_id: {this.Object?.ClientInfo?.LangId}" +
			$"group_id: {this?.GroupId}" +
			$"group_id: {this?.EventID}";
        }
    }
}
