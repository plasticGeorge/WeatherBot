using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace MttfBot.Models
{
	[Serializable]
	public class Callback
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("object")]
		public JObject Object { get; set; }

		[JsonProperty("group_id")]
		public int GroupID { get; set; }

		[JsonProperty("event_id")]
		public string EventID { get; set; }

		[JsonProperty("secret")]
		public string Secret { get; set; }
	}
}
