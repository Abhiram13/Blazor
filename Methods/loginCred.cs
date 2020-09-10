using System;

namespace BlazorApp.Data
{
   class Login
   {
      public static string username { get; set; }
      public static string password { get; set; }
   }

   class Trigger
   {
      public static void Trig()
      {
         Console.WriteLine($"This is Data from POST {Login.username}");
      }
   }
}