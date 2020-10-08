#pragma checksum "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bd29459e08a21b3dd377ecde3505233bdf2ab4c"
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
#line 2 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
using Authorise;

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
#line 8 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
           if (ExistingUser) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "               ");
            __builder.AddMarkupContent(7, "<h4 class=\"text-center mb-3\">Login</h4>         \r\n               ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "style", "background-color: #f3f3f3");
            __builder.AddAttribute(10, "placeholder", "Username");
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "class", "row mx-auto border-0 p-2 rounded col-sm-9 text-center");
            __builder.AddAttribute(13, "value", 
#nullable restore
#line 15 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                            loginUserName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 15 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                                                        (ChangeEventArgs e) => { loginUserName = e.Value.ToString(); checkUser(); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "               \r\n               ");
            __builder.OpenElement(16, "small");
            __builder.AddAttribute(17, "style", "font-size: small; margin-left: 13%; color: red;");
            __builder.AddContent(18, 
#nullable restore
#line 17 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                                                                                userStatusCode == 400 ? "User does not Exist" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n               ");
            __builder.OpenElement(20, "small");
            __builder.AddContent(21, 
#nullable restore
#line 18 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                        passwordloader ? "Loading...." : ""

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 19 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                if (userStatusCode == 200) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                    ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "style", "background-color: #f3f3f3");
            __builder.AddAttribute(26, "placeholder", "password");
            __builder.AddAttribute(27, "type", "text");
            __builder.AddAttribute(28, "class", "row mx-auto mt-3 border-0 p-2 rounded col-sm-9 text-center");
            __builder.AddAttribute(29, "value", 
#nullable restore
#line 25 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                                 loginpassword

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 25 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                                                             (ChangeEventArgs e) => loginpassword = e.Value.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "                    \r\n                    ");
            __builder.OpenElement(32, "small");
            __builder.AddAttribute(33, "style", "font-size: small; margin-left: 13%; color: red;");
            __builder.AddContent(34, 
#nullable restore
#line 27 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                                                                                    errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 28 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
               }

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "               ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "border-0 px-5 mt-3 d-flex mx-auto rounded shadow-sm py-2");
            __builder.AddAttribute(39, "style", "background-color: bisque; font-size: small;");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                                                                                                                                                        () => triggerLogin()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, "Submit");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n               ");
            __builder.OpenElement(43, "p");
            __builder.AddAttribute(44, "class", "text-center mt-4");
            __builder.AddAttribute(45, "style", "font-size: small;");
            __builder.AddContent(46, "Don\'t have an Account? ");
            __builder.OpenElement(47, "span");
            __builder.AddAttribute(48, "style", "color: salmon; cursor: pointer;");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                                                                                                                                                    updateUserExistence

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(50, "Sign Up");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "   \r\n");
#nullable restore
#line 31 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
          } else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "               ");
            __builder.AddMarkupContent(53, "<h4 class=\"text-center mb-3\">Sign In</h4>\r\n               ");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "style", "background-color: #f3f3f3");
            __builder.AddAttribute(56, "class", "row mx-auto mb-3 border-0 p-2 rounded col-sm-9 text-center");
            __builder.AddAttribute(57, "placeholder", "Username");
            __builder.AddAttribute(58, "type", "text");
            __builder.AddAttribute(59, "value", 
#nullable restore
#line 38 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                            Username

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 38 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                                                   (ChangeEventArgs e) => Username = e.Value.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n               ");
            __builder.OpenElement(62, "input");
            __builder.AddAttribute(63, "style", "background-color: #f3f3f3");
            __builder.AddAttribute(64, "class", "row mx-auto mb-3 border-0 p-2 rounded col-sm-9 text-center");
            __builder.AddAttribute(65, "placeholder", "Firstname");
            __builder.AddAttribute(66, "type", "text");
            __builder.AddAttribute(67, "value", 
#nullable restore
#line 45 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                            Firstname

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 45 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                                                    (ChangeEventArgs e) => Firstname = e.Value.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n               ");
            __builder.OpenElement(70, "input");
            __builder.AddAttribute(71, "style", "background-color: #f3f3f3");
            __builder.AddAttribute(72, "class", "row mx-auto mb-3 border-0 p-2 rounded col-sm-9 text-center");
            __builder.AddAttribute(73, "placeholder", "Lastname");
            __builder.AddAttribute(74, "type", "text");
            __builder.AddAttribute(75, "value", 
#nullable restore
#line 52 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                            Lastname

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(76, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 52 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                                                   (ChangeEventArgs e) => Lastname = e.Value.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n               ");
            __builder.OpenElement(78, "input");
            __builder.AddAttribute(79, "style", "background-color: #f3f3f3");
            __builder.AddAttribute(80, "class", "row mx-auto mb-3 border-0 p-2 rounded col-sm-9 text-center");
            __builder.AddAttribute(81, "placeholder", "Password");
            __builder.AddAttribute(82, "type", "text");
            __builder.AddAttribute(83, "value", 
#nullable restore
#line 59 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                            SetPassword

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(84, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 59 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                                                      (ChangeEventArgs e) => SetPassword = e.Value.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n               ");
            __builder.OpenElement(86, "button");
            __builder.AddAttribute(87, "class", "border-0 px-5 d-flex mx-auto rounded shadow-sm py-2");
            __builder.AddAttribute(88, "style", "background-color: bisque; font-size: small;");
            __builder.AddAttribute(89, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                                                                                                                                                 signup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(90, "Submit");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n               ");
            __builder.OpenElement(92, "p");
            __builder.AddAttribute(93, "class", "text-center mt-4");
            __builder.AddAttribute(94, "style", "font-size: small;");
            __builder.AddContent(95, "Have an Account? ");
            __builder.OpenElement(96, "span");
            __builder.AddAttribute(97, "style", "color: salmon; cursor: pointer;");
            __builder.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
                                                                                                                                              updateUserExistence

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(99, "Log In");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n");
#nullable restore
#line 63 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
          }

#line default
#line hidden
#nullable disable
            __builder.AddContent(101, "     ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n\r\n");
            __builder.OpenElement(104, "p");
            __builder.AddContent(105, 
#nullable restore
#line 67 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
    loginUserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n\r\n");
#nullable restore
#line 69 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
 if (status != null) {
     nav.NavigateTo($"/home/{encode(status.username)}/");
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "/Users/abhiramnagadi/Documents/Blazor/Pages/Index.razor"
       
     private string loginUserName { get; set; }
     private string loginpassword { get; set; }
     private string Username { get; set; }
     private string Firstname { get; set; }
     private string Lastname { get; set; }
     private string SetPassword { get; set; }
     private bool ExistingUser { get; set; }
     private LoginResponseBody status { get; set; }
     private bool loader { get; set; }
     private int userStatusCode { get; set; }
     private string errorMessage { get; set; }
     private bool passwordloader;

     // ComponentOnMount
     protected override void OnInitialized() {
          ExistingUser = true;
          loader = false;
     }

     public void updateUserExistence() {
          ExistingUser = !ExistingUser;
     }

     private async void triggerLogin() {
          loader = true;          
          LoginRequestBody.username = loginUserName;
          LoginRequestBody.password = loginpassword;
          int code = Login.statusCode();

          if (loginpassword == null) {
               errorMessage = "Please Enter Password";
               return;
          } else if (code == 200) {
               status = await Login.logUser();               
               return;
          } else if (code == 401) {
               errorMessage = "Wrong Password";
               return;
          }
     }

     public void checkUser() {
          passwordloader = true;
          userStatusCode = Login.UserSearch(loginUserName);
          passwordloader = false;
     }

     public string encode(string str) {
          byte[] bytes = Encoding.UTF8.GetBytes(str);
          return Convert.ToBase64String(bytes);
     }

     public void signup() {
          int statuscode = Login.UserSearch(Username);
          SignUpRequest.username = Username;
          SignUpRequest.firstname = Firstname;
          SignUpRequest.lastname = Lastname;
          SignUpRequest.password = SetPassword;

          if (statuscode == 400) {
               if ((int) AuthoriseSignUp.signUser().StatusCode == 201) {
                    ExistingUser = true;
               } else {
                    ExistingUser = false;
               }
          }
     }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
    }
}
#pragma warning restore 1591
