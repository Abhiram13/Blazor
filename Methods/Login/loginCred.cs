using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using Newtonsoft.Json;

namespace Auth {
     public class Login {
          public static string username { get; set; }
          public static string password { get; set; }
     }

     public class ResponseLogin {
          public string _id { get; set; }
          public string username { get; set; }
          public string firstname { get; set; }
          public string lastname { get; set; }
          public string password { get; set; }
          public string loggedIn { get; set; }
          public bool isAdmin { get; set; }
     }

     public class LoginAuth {
          public async Task<ResponseLogin> UserLogin() {
               HttpClient client = new HttpClient();
               string payload = JsonConvert.SerializeObject(new { login_username = Login.username, login_password = Login.password });
               StringContent content = new StringContent(payload, Encoding.UTF8, "application/json");
               HttpResponseMessage response = client.PostAsync("http://localhost:7000/login.js/", content).Result;
               string json = await response.Content.ReadAsStringAsync();
               ResponseLogin res = JsonConvert.DeserializeObject<ResponseLogin>(json);
               return res;
          }
     }
}