using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CR_DBHelper
{
	internal class CardService
	{
		HttpClient client = new HttpClient();
		string url = "https://retoolapi.dev/yM3igV/people";
		public List<Card> GetAll()
		{
			string json = client.GetStringAsync(url).Result;
			return JsonConvert.DeserializeObject<List<Card>>(json);
		}

		public Card Add(Card card)
		{
			StringContent content = new StringContent(JsonConvert.SerializeObject(card), Encoding.UTF8, "application/Json");
			HttpResponseMessage responseMessage = client.PostAsync(url, content).Result;
			string responseContent = responseMessage.Content.ReadAsStringAsync().Result;
			Debug.WriteLine(responseContent);
			return JsonConvert.DeserializeObject<Card>(responseContent);
		}

		public bool Delete(string urlNew)
		{
			HttpResponseMessage response = (client.DeleteAsync(urlNew)).Result;
			return response.IsSuccessStatusCode;
		}

		public Card Update(int id, Card card)
		{
			string urlNew = "https://retoolapi.dev/yM3igV/people/" + id;
			StringContent content = new StringContent(JsonConvert.SerializeObject(card), Encoding.UTF8, "application/Json");
			HttpResponseMessage response = (client.PatchAsync(urlNew, content)).Result;
			string responseContent = response.Content.ReadAsStringAsync().Result;
			Debug.WriteLine(responseContent);
			return JsonConvert.DeserializeObject<Card>(responseContent);
		}
	}
}
