#pragma checksum "/Users/abhiramnagadi/Documents/Blazor/Pages/Home.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "865e0731551e572a16b777744c0c4c5c2960f7b1"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/home/{Id}")]
    public partial class Home : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "/Users/abhiramnagadi/Documents/Blazor/Pages/Home.razor"
 
     [Parameter]
     public string Id { get; set; }
     public Mordor[] M { get; set; }
     public Mordor[] Filter { get; set; }
     public string value { get; set; }

     protected override void OnParametersSet() {
          var x = Id;
     }

     // fetching all items in DB
     protected override async Task OnInitializedAsync() {
          M = await ItemsRequest.MordorRequest();
     }

     protected async Task GetFilteredData(string value) {
          Filter = await Srch.SearchItem(value);
     }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Search Srch { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SearchAttributes S { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Mordor Mordor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GetRequest ItemsRequest { get; set; }
    }
}
#pragma warning restore 1591
