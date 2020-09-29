using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Auth;

namespace BlazorApp {
     public class Program {
          // static async Task Main()
          // {
          //    GetRequest get = new GetRequest();
          //    var docs = await get.MordorRequest();
          //    foreach (var list in docs)
          //    {
          //       Console.WriteLine(list.itemName);
          //    }
          // }

          public static void Main(string[] args) {
               CreateHostBuilder(args).Build().Run();
          }

          public static IHostBuilder CreateHostBuilder(string[] args) =>
              Host.CreateDefaultBuilder(args)
                  .ConfigureWebHostDefaults(webBuilder => {
                       webBuilder.UseStartup<Startup>();
                  });
     }
}
