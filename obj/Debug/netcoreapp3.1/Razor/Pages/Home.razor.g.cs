#pragma checksum "/Users/abhiramnagadi/Documents/Blazor/Pages/Home.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59b965e57e33adb0a698f0fc2ae2dc70d4ea3559"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/abhiramnagadi/Documents/Blazor/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/abhiramnagadi/Documents/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/abhiramnagadi/Documents/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/abhiramnagadi/Documents/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/abhiramnagadi/Documents/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/abhiramnagadi/Documents/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/abhiramnagadi/Documents/Blazor/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/abhiramnagadi/Documents/Blazor/_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/abhiramnagadi/Documents/Blazor/_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/abhiramnagadi/Documents/Blazor/Pages/Home.razor"
using User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/abhiramnagadi/Documents/Blazor/Pages/Home.razor"
using Authorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/abhiramnagadi/Documents/Blazor/Pages/Home.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/abhiramnagadi/Documents/Blazor/Pages/Home.razor"
using Item;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/home/{Id}")]
    public partial class Home : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "input");
            __builder.AddAttribute(1, "type", "text");
            __builder.AddAttribute(2, "placeholder", "Search");
            __builder.AddAttribute(3, "class", "mx-auto d-block form-control col-sm-2 p-0 text-center");
            __builder.AddAttribute(4, "value", 
#nullable restore
#line 8 "/Users/abhiramnagadi/Documents/Blazor/Pages/Home.razor"
                                                                                                              value

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 8 "/Users/abhiramnagadi/Documents/Blazor/Pages/Home.razor"
                                                                                                                                 (ChangeEventArgs e) => searchItem(e.Value.ToString(), ItemsCopy)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n\n");
            __builder.OpenElement(7, "section");
            __builder.AddAttribute(8, "class", "container mx-auto p-0 mt-5");
            __builder.AddMarkupContent(9, "\n     ");
            __builder.OpenElement(10, "section");
            __builder.AddAttribute(11, "class", "bg-white rounded mx-auto col-sm-10 p-0");
            __builder.AddMarkupContent(12, "\n          ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "d-flex flex-wrap p-3");
            __builder.AddMarkupContent(15, "\n");
#nullable restore
#line 13 "/Users/abhiramnagadi/Documents/Blazor/Pages/Home.razor"
                if (Items != null) {
                   foreach (ItemsResponseBody item in Items) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "p-2 shadow rounded mb-3 mr-4");
            __builder.AddAttribute(19, "style", "width: 30%; border-radius: 10px; background-color: aliceblue;");
            __builder.AddMarkupContent(20, "\n                             ");
            __builder.OpenElement(21, "img");
            __builder.AddAttribute(22, "alt", 
#nullable restore
#line 16 "/Users/abhiramnagadi/Documents/Blazor/Pages/Home.razor"
                                        item.itemName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(23, "class", "col-sm p-0 rounded");
            __builder.AddAttribute(24, "src", 
#nullable restore
#line 16 "/Users/abhiramnagadi/Documents/Blazor/Pages/Home.razor"
                                                                                        item.imageURL

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                             ");
            __builder.OpenElement(26, "h6");
            __builder.AddAttribute(27, "class", "m-0 mt-3");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "/Users/abhiramnagadi/Documents/Blazor/Pages/Home.razor"
                                                            () => redirectToDetails(Id, item.itemName)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, 
#nullable restore
#line 17 "/Users/abhiramnagadi/Documents/Blazor/Pages/Home.razor"
                                                                                                          item.itemName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n                             ");
            __builder.OpenElement(31, "small");
            __builder.AddContent(32, 
#nullable restore
#line 18 "/Users/abhiramnagadi/Documents/Blazor/Pages/Home.razor"
                                     item.category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n");
#nullable restore
#line 20 "/Users/abhiramnagadi/Documents/Blazor/Pages/Home.razor"
                   }
               } else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "                    ");
            __builder.AddMarkupContent(36, "<h5>No Results Found</h5>\n");
#nullable restore
#line 23 "/Users/abhiramnagadi/Documents/Blazor/Pages/Home.razor"
               }

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n     ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "/Users/abhiramnagadi/Documents/Blazor/Pages/Home.razor"
 
     [Parameter]
     public string Id { get; set; }
     public LoginResponseBody ResponseBody;
     protected ItemsResponseBody[] Items;
     public ItemsResponseBody[] ItemsCopy;
     public string value;

     protected override void OnInitialized() {
          if (Id == null) return;
          Items = ItemsCopy = GetItems.fetchItems();
     }

     protected async override void OnParametersSet() {
          if (Id == null) return;
          string userId = Encoding.UTF8.GetString(Convert.FromBase64String(Id));
          ResponseBody = await FindUser.getUser(userId);
     }     

     public void searchItem(string key, ItemsResponseBody[] data) {
          value = key;
          System.Collections.Generic.List<ItemsResponseBody> list = new List<ItemsResponseBody>();

          for (int i = 0; i < data.Length; i++) {
               if (key.StartsWith("@")) {         
                    if (key.Length >= 2) {
                         if (key.Substring(1, key.Length - 1).ToUpper() == data[i].category.Substring(0, key.Length - 1).ToUpper()) {
                              list.Add(data[i]);
                         }
                    } else return;                       
               } else if (key.ToUpper() == data[i].itemName.Substring(0, key.Length).ToUpper()) {
                    list.Add(data[i]);
               }
          }

          Items = list.Count > 0 ? list.ToArray() : null;
     }

     public void redirectToDetails(string userid, string itemid) {
          string itemId = Convert.ToBase64String(Encoding.UTF8.GetBytes(itemid));
          Nav.NavigateTo($"/details/{userid}/{itemId}/");
     }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Nav { get; set; }
    }
}
#pragma warning restore 1591
