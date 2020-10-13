using System;
using MongoDB.Bson;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.Json;

namespace Item {
     public class ItemsResponseBody {
          public ObjectId _id { get; set; }
          public string itemName { get; set; }
          public string description { get; set; }
          public string category { get; set; }
          public string imageURL { get; set; }
          public string categoryLogo { get; set; }
          public int rating { get; set; }
          public int __v { get; set; }
     }

     public class GetItems {
          public static ItemsResponseBody[] fetchItems() {
               HttpClient client = new HttpClient();
               string response = client.GetStringAsync("http://localhost:1995/getItems/").Result;
               List<ItemsResponseBody> list = JsonSerializer.Deserialize<List<ItemsResponseBody>>(response);
               return list.ToArray();
          }
     }

     public class FindItem {
          public static async Task<ItemsResponseBody> findItem(string item) {
               HttpClient client = new HttpClient();
               string json = JsonSerializer.Serialize(new { itemName = item });
               StringContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
               HttpResponseMessage response = client.PostAsync("http://localhost:1995/Find/", content).Result;
               string responseString = await response.Content.ReadAsStringAsync();
               ItemsResponseBody Item = JsonSerializer.Deserialize<ItemsResponseBody>(responseString);
               return Item;
          }
     }
}