using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text;

namespace Authorise {
     public class LoginRequestBody {
          public static string username { get; set; }
          public static string password { get; set; }
     }

     public class LoginResponseBody {
          public MongoDB.Bson.ObjectId _id { get ; set ;}
          public string username { get; set; }
          public string firstname { get; set; }
          public string lastname { get; set; }
          public string password { get; set; }
          public bool isAdmin { get; set; }
          public int __v { get; set; }
     }

     public class Login {
          private static HttpClient client = new HttpClient();
          private static HttpResponseMessage responseMessage;       

          public static int UserSearch(string username) {
               string requestbody = JsonSerializer.Serialize(new { username = username });
               StringContent content = new StringContent(requestbody, Encoding.UTF8, "application/json");
               HttpResponseMessage response = client.PostAsync("http://localhost:1995/FindUser/", content).Result;
               return (int) response.StatusCode;
          }   

          public static int statusCode() {
               string json = JsonSerializer.Serialize(new { username = LoginRequestBody.username, password = LoginRequestBody.password });
               StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
               responseMessage = client.PostAsync("http://localhost:1995/login/", content).Result;
               Console.WriteLine((int)responseMessage.StatusCode);
               return (int) responseMessage.StatusCode;
          }
          
          public static async Task<LoginResponseBody> logUser() {
               string str = await responseMessage.Content.ReadAsStringAsync();
               LoginResponseBody res = JsonSerializer.Deserialize<LoginResponseBody>(str);
               return res;
          }
     }
}