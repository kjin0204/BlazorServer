#pragma checksum "D:\4.learn\BlazorApp\BlazorApp\Pages\User.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc7b6a0a7b7cd80407ce3be23dcc42aad67685c3"
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
#line 1 "D:\4.learn\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\4.learn\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\4.learn\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\4.learn\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\4.learn\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\4.learn\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\4.learn\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\4.learn\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\4.learn\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\4.learn\BlazorApp\BlazorApp\Pages\User.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/user")]
    public partial class User : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Online users</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<label>Theme Color:</label>\r\n");
            __builder.OpenElement(2, "select");
            __builder.AddAttribute(3, "class", "form-control");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "D:\4.learn\BlazorApp\BlazorApp\Pages\User.razor"
                                    _selectedColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _selectedColor = __value, _selectedColor));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(6, "\r\n\r\n");
#nullable restore
#line 10 "D:\4.learn\BlazorApp\BlazorApp\Pages\User.razor"
     foreach (var option in _options)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "        ");
            __builder.OpenElement(8, "option");
            __builder.AddAttribute(9, "value", 
#nullable restore
#line 12 "D:\4.learn\BlazorApp\BlazorApp\Pages\User.razor"
                        option

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.AddContent(11, 
#nullable restore
#line 13 "D:\4.learn\BlazorApp\BlazorApp\Pages\User.razor"
             option

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 15 "D:\4.learn\BlazorApp\BlazorApp\Pages\User.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __Blazor.BlazorApp.Pages.User.TypeInference.CreateCascadingValue_0(__builder, 15, 16, "themsColor", 17, 
#nullable restore
#line 18 "D:\4.learn\BlazorApp\BlazorApp\Pages\User.razor"
                                         _selectedColor

#line default
#line hidden
#nullable disable
            , 18, (__builder2) => {
                __builder2.AddMarkupContent(19, "\r\n    ");
                __builder2.OpenComponent<BlazorApp.Pages.ShowUser>(20);
                __builder2.AddAttribute(21, "Users", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorApp.Data.UserData>>(
#nullable restore
#line 19 "D:\4.learn\BlazorApp\BlazorApp\Pages\User.razor"
                      _users

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "CallBackTest", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 19 "D:\4.learn\BlazorApp\BlazorApp\Pages\User.razor"
                                            CallbackTest

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n");
            }
            );
            __builder.AddMarkupContent(24, "\r\n<br>\r\n\r\n\r\n");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "container");
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "row");
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col");
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "class", "form-control");
            __builder.AddAttribute(36, "placeholder", "Add User");
            __builder.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "D:\4.learn\BlazorApp\BlazorApp\Pages\User.razor"
                                                                             _inputName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _inputName = __value, _inputName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "col");
            __builder.AddMarkupContent(43, "\r\n            \r\n            ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "class", 
#nullable restore
#line 31 "D:\4.learn\BlazorApp\BlazorApp\Pages\User.razor"
                            _btnClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(46, "type", "button");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "D:\4.learn\BlazorApp\BlazorApp\Pages\User.razor"
                                                               AddUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "disabled", 
#nullable restore
#line 31 "D:\4.learn\BlazorApp\BlazorApp\Pages\User.razor"
                                                                                    _users.Count >= 5

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(49, "Add a User");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "D:\4.learn\BlazorApp\BlazorApp\Pages\User.razor"
       
    string _selectedColor = "Red";
    List<string> _options = new List<string>() { "Green", "Red", "blue" };

    List<UserData> _users = new List<UserData>();
    //ShowUser _showUser;

    string _inputName;
    string _btnClass = "btn btn-primary";

    void AddUser()
    {

        _users.Add(new UserData() { Name = _inputName });
    }

    void CallbackTest()
    {
        _inputName = "CallbackTest";
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorApp.Pages.User
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
