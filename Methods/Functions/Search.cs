using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
   public class SearchAttributes 
   {
      public Mordor[] Items { get; set; }
      public Mordor[] FilteredArray { get; set; }
   }

   public class Search
   {
      public async Task<Mordor[]> SearchItem(string value)
      {
         GetRequest request = new GetRequest();
         SearchAttributes Srch = new SearchAttributes();
         Srch.Items = await request.MordorRequest();
         List<Mordor> list = new List<Mordor>();
         for (int i = 0; i < Srch.Items.Length; i++)
         {
            if (Srch.Items[i].itemName.Substring(0, value.Length) == value)
            {
               list.Add(Srch.Items[i]);
            }
         }
         return list.ToArray();
      }
   }   
}