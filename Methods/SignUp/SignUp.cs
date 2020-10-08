using System;
using System.Net.Http;
using System.Text.Json;
using System.Text;

namespace Authorise {
     public class SignUpRequest : LoginRequestBody {
          public static string firstname { get; set; }
          public static string lastname { get; set; }
          public static bool isAdmin { get; set; }
     }

     public class AuthoriseSignUp {
          static HttpClient http = new HttpClient();

          public static HttpResponseMessage signUser() {
               string json = JsonSerializer.Serialize(new {
                    username = SignUpRequest.username,
                    firstname = SignUpRequest.firstname,
                    lastname = SignUpRequest.lastname,
                    password = SignUpRequest.password,
                    isAdmin = SignUpRequest.isAdmin
               });

               StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
               HttpResponseMessage response = http.PostAsync("http://localhost:1995/signin/", content).Result;
               return response;
          }
     }
}