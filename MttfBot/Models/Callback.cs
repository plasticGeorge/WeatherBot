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
		public string Object { get; set; }

		[JsonProperty("group_id")]
		public long GroupId { get; set; }

		[JsonProperty("event_id")]
		public string EventID { get; set; }

		[JsonProperty("secret")]
		public string Secret { get; set; }
	}
}
