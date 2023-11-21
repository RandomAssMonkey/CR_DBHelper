using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR_DBHelper
{
	internal class Card
	{
		[JsonProperty(PropertyName = "id")]
		public int Id { get; set; }
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }
		[JsonProperty(PropertyName = "arena")]
		public int Arena {get; set; }
		[JsonProperty(PropertyName = "type")]
		public string Type {get; set; }
		[JsonProperty(PropertyName = "rarity")]
		public string Rarity { get; set; }
		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }
		[JsonProperty(PropertyName = "guessed")]
		public bool Guessed { get; set; }
	}
}
