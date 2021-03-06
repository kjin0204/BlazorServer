#pragma checksum "D:\4.learn\BlazorApp\BlazorApp\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d8238a74b12eaf8b0bf223f3258b329ae025ad0"
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
#line 3 "D:\4.learn\BlazorApp\BlazorApp\Pages\FetchData.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n");
#nullable restore
#line 10 "D:\4.learn\BlazorApp\BlazorApp\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 13 "D:\4.learn\BlazorApp\BlazorApp\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "    \r\n");
            __builder.OpenComponent<BlazorApp.Pages.TableTemplate<WeatherForecast>>(5);
            __builder.AddAttribute(6, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IReadOnlyList<WeatherForecast>>(
#nullable restore
#line 17 "D:\4.learn\BlazorApp\BlazorApp\Pages\FetchData.razor"
                      forecasts

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.AddMarkupContent(9, "<th>Date</th>\r\n        ");
                __builder2.AddMarkupContent(10, "<th>Temp. (C)</th>\r\n        ");
                __builder2.AddMarkupContent(11, "<th>Temp. (F)</th>\r\n        ");
                __builder2.AddMarkupContent(12, "<th>Summary</th>\r\n    ");
            }
            ));
            __builder.AddAttribute(13, "Row", (Microsoft.AspNetCore.Components.RenderFragment<WeatherForecast>)((forecast) => (__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenElement(15, "td");
                __builder2.AddContent(16, 
#nullable restore
#line 27 "D:\4.learn\BlazorApp\BlazorApp\Pages\FetchData.razor"
             forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenElement(18, "td");
                __builder2.AddContent(19, 
#nullable restore
#line 28 "D:\4.learn\BlazorApp\BlazorApp\Pages\FetchData.razor"
             forecast.TemperatureC

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenElement(21, "td");
                __builder2.AddContent(22, 
#nullable restore
#line 29 "D:\4.learn\BlazorApp\BlazorApp\Pages\FetchData.razor"
             forecast.TemperatureF

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.OpenElement(24, "td");
                __builder2.AddContent(25, 
#nullable restore
#line 30 "D:\4.learn\BlazorApp\BlazorApp\Pages\FetchData.razor"
             forecast.Summary

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 34 "D:\4.learn\BlazorApp\BlazorApp\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "D:\4.learn\BlazorApp\BlazorApp\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
