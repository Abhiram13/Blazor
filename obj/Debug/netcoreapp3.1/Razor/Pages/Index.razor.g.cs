#pragma checksum "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f5342b1852adb2a85c49d0c5be2f09b75a072c5"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "container p-0 mx-auto mt-5");
            __builder.AddMarkupContent(2, "\r\n     ");
            __builder.OpenElement(3, "section");
            __builder.AddAttribute(4, "class", "col-sm-5 p-0 bg-white shadow mx-auto p-3 rounded");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 5 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
           if (ExistingUser)
          {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "               ");
            __builder.AddMarkupContent(7, "<h4 class=\"text-center mb-3\">Login</h4>         \r\n               ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "style", "background-color: #f3f3f3");
            __builder.AddAttribute(10, "placeholder", "Username");
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "class", "row mx-auto mb-3 border-0 p-2 rounded col-sm-9 text-center");
            __builder.AddAttribute(13, "value", 
#nullable restore
#line 13 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                            CurrentValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 13 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                                                       (ChangeEventArgs e) => CurrentValue = e.Value.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n               ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "style", "background-color: #f3f3f3");
            __builder.AddAttribute(18, "placeholder", "password");
            __builder.AddAttribute(19, "type", "text");
            __builder.AddAttribute(20, "class", "row mx-auto mb-3 border-0 p-2 rounded col-sm-9 text-center");
            __builder.AddAttribute(21, "value", 
#nullable restore
#line 20 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                            Password

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 20 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                                                   (ChangeEventArgs e) => Password = e.Value.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n               ");
            __builder.AddMarkupContent(24, "<button class=\"border-0 px-5 d-flex mx-auto rounded shadow-sm py-2\" style=\"background-color: bisque; font-size: small;\">Submit</button>\r\n               ");
            __builder.OpenElement(25, "p");
            __builder.AddAttribute(26, "class", "text-center mt-4");
            __builder.AddAttribute(27, "style", "font-size: small;");
            __builder.AddContent(28, "Don\'t have an Account? ");
            __builder.OpenElement(29, "span");
            __builder.AddAttribute(30, "style", "color: salmon; cursor: pointer;");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                                                                                                                                                    updateUserExistence

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Sign Up");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "   \r\n");
#nullable restore
#line 24 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
          } else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "               ");
            __builder.AddMarkupContent(35, "<h4 class=\"text-center mb-3\">Sign In</h4>\r\n               ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "style", "background-color: #f3f3f3");
            __builder.AddAttribute(38, "class", "row mx-auto mb-3 border-0 p-2 rounded col-sm-9 text-center");
            __builder.AddAttribute(39, "placeholder", "Username");
            __builder.AddAttribute(40, "type", "text");
            __builder.AddAttribute(41, "value", 
#nullable restore
#line 31 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                            Username

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 31 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                                                   (ChangeEventArgs e) => Username = e.Value.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n               ");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "style", "background-color: #f3f3f3");
            __builder.AddAttribute(46, "class", "row mx-auto mb-3 border-0 p-2 rounded col-sm-9 text-center");
            __builder.AddAttribute(47, "placeholder", "Firstname");
            __builder.AddAttribute(48, "type", "text");
            __builder.AddAttribute(49, "value", 
#nullable restore
#line 38 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                            Firstname

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 38 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                                                    (ChangeEventArgs e) => Firstname = e.Value.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n               ");
            __builder.OpenElement(52, "input");
            __builder.AddAttribute(53, "style", "background-color: #f3f3f3");
            __builder.AddAttribute(54, "class", "row mx-auto mb-3 border-0 p-2 rounded col-sm-9 text-center");
            __builder.AddAttribute(55, "placeholder", "Lastname");
            __builder.AddAttribute(56, "type", "text");
            __builder.AddAttribute(57, "value", 
#nullable restore
#line 45 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                            Lastname

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 45 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                                                   (ChangeEventArgs e) => Lastname = e.Value.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n               ");
            __builder.OpenElement(60, "input");
            __builder.AddAttribute(61, "style", "background-color: #f3f3f3");
            __builder.AddAttribute(62, "class", "row mx-auto mb-3 border-0 p-2 rounded col-sm-9 text-center");
            __builder.AddAttribute(63, "placeholder", "Password");
            __builder.AddAttribute(64, "type", "text");
            __builder.AddAttribute(65, "value", 
#nullable restore
#line 52 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                            SetPassword

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 52 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                                                      (ChangeEventArgs e) => SetPassword = e.Value.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n               ");
            __builder.AddMarkupContent(68, "<button class=\"border-0 px-5 d-flex mx-auto rounded shadow-sm py-2\" style=\"background-color: bisque; font-size: small;\">Submit</button>\r\n               ");
            __builder.OpenElement(69, "p");
            __builder.AddAttribute(70, "class", "text-center mt-4");
            __builder.AddAttribute(71, "style", "font-size: small;");
            __builder.AddContent(72, "Have an Account? ");
            __builder.OpenElement(73, "span");
            __builder.AddAttribute(74, "style", "color: salmon; cursor: pointer;");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                                                                                                                                              updateUserExistence

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(76, "Log In");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 56 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
          }

#line default
#line hidden
#nullable disable
            __builder.AddContent(78, "     ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
       
     private string CurrentValue { get; set; }
     private string Password { get; set; }
     private string Username { get; set; }
     private string Firstname { get; set; }
     private string Lastname { get; set; }
     private string SetPassword { get; set; }
     private bool ExistingUser { get; set; }

     // ComponentOnMount
     protected override void OnInitialized() {
          ExistingUser = true;
     }

     public void updateUserExistence() {
          ExistingUser = !ExistingUser;
     }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
