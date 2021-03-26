using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Text.Json.Serialization;

namespace MttfBot.Models
{
	[Serializable]
	public class Callback
	{
		[JsonPropertyName("type")]
		public string Type { get; set; }

		[JsonPropertyName("object")]
		public JObject Object { get; set; }

		[JsonPropertyName("group_id")]
		public int GroupID { get; set; }

		[JsonPropertyName("event_id")]
		public string EventID { get; set; }

		[JsonProperty("secret")]
		public string Secret { get; set; }
	}
}
