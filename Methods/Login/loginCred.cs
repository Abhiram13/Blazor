using System;
using System.Net.Http;
using MongoDB.Driver;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text;

namespace Authorise {
     public class LoginRequestBody {
          public static string username { get; set; }
     }

     public class LoginResponseBody {
          public MongoDB.Bson.ObjectId _id { get; set; }
          public string username { get; set; }
          public string firstname { get; set; }
          public string lastname { get; set; }
          public string password { get; set; }
          public bool isAdmin { get; set; }
          public int __v { get; set; }
     }

     class Login {
          public async Task<LoginResponseBody> logUser() {
               HttpClient client = new HttpClient();
               string json = JsonSerializer.Serialize(new { username = LoginRequestBody.username });
               StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
               HttpResponseMessage loginResponse = client.PostAsync("http://localhost:1995/login/", content).Result;
               string str = await loginResponse.Content.ReadAsStringAsync();
               LoginResponseBody res = JsonSerializer.Deserialize<LoginResponseBody>(str);
               return res;
               // return (int) loginResponse.StatusCode;
          }
     }
}