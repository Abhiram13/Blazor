using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Text;

namespace Auth
{
   class SignUp
   {
      public static string username { get; set; }
      public static string firstname { get; set; }
      public static string lastname { get; set; }
      public static string password { get; set; }
   }

   class CreateUser
   {
      async Task<SignUp> SetUser()
      {
         // make an instance of HttpClient
         HttpClient http = new HttpClient();

         // create data for post request
         // using Json Serialize Object, 
         // thus converting it into stringify Json
         string data = JsonConvert.SerializeObject(new { 
            userName = SignUp.username, 
            firstName = SignUp.firstname, 
            lastName = SignUp.lastname, 
            passWord = SignUp.password 
         });

         // attaching headers
         StringContent str = new StringContent(data, Encoding.UTF8, "application/json");

         // making post request and getting the data
         HttpResponseMessage res = http.PostAsync("http://localhost:7000/signIn.js", str).Result;

         // converting data into string Json
         string responseData = await res.Content.ReadAsStringAsync();

         // converting Json string into object
         SignUp d = JsonConvert.DeserializeObject<SignUp>(responseData);

         // returning object
         return d;
      }
   }
}