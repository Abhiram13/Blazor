using System;

namespace Auth
{
   public class Login
   {
      public static string username { get; set; }
      public static string password { get; set; }
   }

   public class Trigger
   {
      public static void Trig()
      {
         Console.WriteLine($"This is Data from POST {Login.username}");
      }
   }
}