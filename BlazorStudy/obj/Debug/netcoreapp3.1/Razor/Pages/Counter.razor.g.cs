#pragma checksum "D:\4.learn\BlazorApp\BlazorStudy\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "192b9c3f812f22f420110c0e824a9295e7fbed62"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorStudy.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\4.learn\BlazorApp\BlazorStudy\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\4.learn\BlazorApp\BlazorStudy\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\4.learn\BlazorApp\BlazorStudy\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\4.learn\BlazorApp\BlazorStudy\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\4.learn\BlazorApp\BlazorStudy\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\4.learn\BlazorApp\BlazorStudy\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\4.learn\BlazorApp\BlazorStudy\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\4.learn\BlazorApp\BlazorStudy\_Imports.razor"
using BlazorStudy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\4.learn\BlazorApp\BlazorStudy\_Imports.razor"
using BlazorStudy.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout2))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter/{currentCount1:int}")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 7 "D:\4.learn\BlazorApp\BlazorStudy\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "D:\4.learn\BlazorApp\BlazorStudy\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "D:\4.learn\BlazorApp\BlazorStudy\Pages\Counter.razor"
       
    //private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;

        navManager.NavigateTo("FetchData");
    }

    [Parameter]
    public int currentCount { get; set; }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
    }
}
#pragma warning restore 1591
