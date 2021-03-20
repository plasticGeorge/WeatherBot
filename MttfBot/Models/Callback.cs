using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MttfBot.Models
{
	[Serializable]
	public class Callback
	{
		[JsonProperty("type")]
		public JValue Type { get; set; }

		[JsonProperty("object")]
		public JObject Object { get; set; }

		[JsonProperty("group_id")]
		public JValue GroupId { get; set; }

		[JsonProperty("event_id")]
		public JValue EventID { get; set; }

		[JsonProperty("secret")]
		public JValue Secret { get; set; }
	}
}
