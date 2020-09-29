using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlazorApp.Data {
     public class GetRequest {
          public async Task<Mordor[]> MordorRequest() {
               var client = new HttpClient();
               var result = await client.GetStringAsync("http://localhost:7000/getItem");
               List<Mordor> docs = JsonConvert.DeserializeObject<List<Mordor>>(result);
               Mordor[] d = docs.ConvertAll<Mordor>(item => (Mordor)item).ToArray();
               return d;
          }
     }
}