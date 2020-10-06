using System;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using Authorise;
using System.Threading.Tasks;

namespace User {
     public class FindUser {
          public static async Task<LoginResponseBody> getUser(string userId) {
               HttpClient client = new HttpClient();
               string json = JsonSerializer.Serialize(new { username = userId });
               StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
               HttpResponseMessage responseMessage = client.PostAsync("http://localhost:1995/FindUser/", content).Result;
               string str = await responseMessage.Content.ReadAsStringAsync();
               LoginResponseBody res = JsonSerializer.Deserialize<LoginResponseBody>(str);
               return res;
          }
     }
}