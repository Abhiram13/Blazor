using System;
using System.Net.Http;
using MongoDB.Driver;
using System.Text.Json;

namespace Authorise {
     class LoginRequestBody {
          public string username { get; set; }
     }

     class LoginResponseBody {
          public MongoDB.Bson.ObjectId _id { get; set; }
          public string username { get; set; }
          public string firstname { get; set; }
          public string lastname { get; set; }
          public string password { get; set; }
          public string isAdmin { get; set; }
          public int __v { get; set; }
     }

     class Login {
          public static int logUser() {
               HttpClient client = new HttpClient();
               string json = JsonSerializer.Serialize(new LoginRequestBody().username);
               StringContent content = new StringContent(json);
               HttpResponseMessage loginResponse = client.PostAsync("http://localhost:1995/login/", content).Result;
               return (int) loginResponse.StatusCode;
          }
     }
}