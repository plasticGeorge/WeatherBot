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
		public int GroupId { get; set; }

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
			$"\t\tdate: {this.Object?.Message?.Date}\n" +
			$"\t\tfrom_id: {this.Object?.Message?.FromId}\n" +
			$"\t\tid: {this.Object?.Message?.Id}\n" +
			$"\t\tout: {this.Object?.Message?.Out}\n" +
			$"\t\tpeer_id: {this.Object?.Message?.PeerId}\n" +
			$"\t\ttext: {this.Object?.Message?.Text}\n" +
			$"\t\tconversation_message_id: {this.Object?.Message?.ConversationMessageId}\n" +
			$"\t\tfwd_messages: -\n" +
			$"\t\timportant: {this.Object?.Message?.Important}\n" +
			$"\t\trandom_id: {this.Object?.Message?.RandomId}\n" +
			$"\t\tattachments: -\n" +
			$"\t\tis_hidden: {this.Object?.Message?.IsHidden}\n" +
			$"\tclient_info:\n" +
			$"\t\tbutton_actions: [\n" +
			$"\t\t\t{this.Object?.ClientInfo?.ButtonActions[0]}\n" +
			$"\t\t\t{this.Object?.ClientInfo?.ButtonActions[1]}\n" +
			$"\t\t\t{this.Object?.ClientInfo?.ButtonActions[2]}\n" +
			$"\t\t\t{this.Object?.ClientInfo?.ButtonActions[3]}\n" +
			$"\t\t\t{this.Object?.ClientInfo?.ButtonActions[4]}\n" +
			$"\t\t\t{this.Object?.ClientInfo?.ButtonActions[5]}\n" +
			$"\t\t\t{this.Object?.ClientInfo?.ButtonActions[6]}\n" +
			$"\t\t\t{this.Object?.ClientInfo?.ButtonActions[7]}\n" +
			$"\t\t\t]\n" +
			$"\t\tkeyboard: {this.Object?.ClientInfo?.Keyboard}\n" +
			$"\t\tinline_keyboard: {this.Object?.ClientInfo?.InlineKeyboard}\n" +
			$"\t\tcarousel: {this.Object?.ClientInfo?.Carousel}\n" +
			$"\t\tlang_id: {this.Object?.ClientInfo?.LangId}\n" +
			$"group_id: {this?.GroupId}\n" +
			$"event_id: {this?.EventID}\n";
		}
	}
}
