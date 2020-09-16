using System;

namespace BlazorApp.Data
{
   public class Mordor
   {
      public string _id { get; set; }
      public string itemName { get; set; }
      public string description { get; set; }
      public string category { get; set; }
      public string imageURL { get; set; }
      public int rating { get; set; }
      public string categoryLogo { get; set; }
   }
}