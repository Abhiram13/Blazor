#pragma checksum "/Users/abhiramnagadi/Documents/Blazor/Pages/Home.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e05009b56f89140e9b73e3c0a710894ac7f81ca4"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/home/{Id}")]
    public partial class Home : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, "This is Home Page and the id is ");
            __builder.AddContent(2, 
#nullable restore
#line 4 "/Users/abhiramnagadi/Documents/Blazor/Pages/Home.razor"
                                     Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "/Users/abhiramnagadi/Documents/Blazor/Pages/Home.razor"
 
   [Parameter]
   public string Id { get; set; }

   protected override void OnParametersSet()
   {
      var x = Id;
   }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591