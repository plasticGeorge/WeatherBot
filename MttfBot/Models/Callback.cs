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
			$"type: {Type}\n" +
			$"object:\n" +
			$"\tmessage:\n" +
			$"\t\tdate: {Object.Message.Date}" +
			$"\t\tfrom_id: {Object.Message.FromId}" +
			$"\t\tid: {Object.Message.Id}" +
			$"\t\tout: {Object.Message.Out}" +
			$"\t\tpeer_id: {Object.Message.PeerId}" +
			$"\t\ttext: {Object.Message.Text}" +
			$"\t\tconversation_message_id: {Object.Message.ConversationMessageId}" +
			$"\t\tfwd_messages: -" +
			$"\t\timportant: {Object.Message.Important}" +
			$"\t\trandom_id: {Object.Message.RandomId}" +
			$"\t\tattachments: -" +
			$"\t\tis_hidden: {Object.Message.IsHidden}" +
			$"\tclient_info:" +
			$"\t\tbutton_actions: [" +
			$"\t\t\t{Object.ClientInfo.ButtonActions[0]}" +
			$"\t\t\t{Object.ClientInfo.ButtonActions[1]}" +
			$"\t\t\t{Object.ClientInfo.ButtonActions[2]}" +
			$"\t\t\t{Object.ClientInfo.ButtonActions[3]}" +
			$"\t\t\t{Object.ClientInfo.ButtonActions[4]}" +
			$"\t\t\t{Object.ClientInfo.ButtonActions[5]}" +
			$"\t\t\t{Object.ClientInfo.ButtonActions[6]}" +
			$"\t\t\t{Object.ClientInfo.ButtonActions[7]}" +
			$"\t\t\t]" +
			$"\t\tkeyboard: {Object.ClientInfo.Keyboard}" +
			$"\t\tinline_keyboard: {Object.ClientInfo.InlineKeyboard}" +
			$"\t\tcarousel: {Object.ClientInfo.Carousel}" +
			$"\t\tlang_id: {Object.ClientInfo.LangId}" +
			$"group_id: {GroupId}" +
			$"group_id: {EventID}";
        }
    }
}
