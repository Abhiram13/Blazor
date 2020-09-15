using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Text;

namespace Auth
{
   public class SignUpObject
   {
      public static string username { get; set; }
      public static string firstname { get; set; }
      public static string lastname { get; set; }
      public static string password { get; set; }
   }

   public class Create
   {
      public async Task<string> CreateUser()
      {
         // make an instance of HttpClient
         HttpClient http = new HttpClient();

         // create data for post request
         // using Json Serialize Object, 
         // thus converting it into stringify Json
         string data = JsonConvert.SerializeObject(new { 
            userName = SignUpObject.username, 
            firstName = SignUpObject.firstname, 
            lastName = SignUpObject.lastname, 
            passWord = SignUpObject.password
         });

         // attaching headers
         StringContent str = new StringContent(data, Encoding.UTF8, "application/json");

         // making post request and getting the data
         HttpResponseMessage res = http.PostAsync("http://localhost:7000/signIn.js", str).Result;

         Console.WriteLine(res);

         // converting data into string Json
         string responseData = await res.Content.ReadAsStringAsync();

         // returning object
         return responseData;
      }
   }
}