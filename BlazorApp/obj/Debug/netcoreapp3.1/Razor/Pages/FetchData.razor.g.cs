#pragma checksum "D:\4.learn\BlazorApp\BlazorApp\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b13f91c7499cb6f2acd6cec8a0cf7802ac63e096"
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
 if (_forecasts == null)
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
            __builder.AddMarkupContent(4, "    \r\n    ");
            __builder.OpenComponent<BlazorApp.Pages.TableTemplate<WeatherForecast>>(5);
            __builder.AddAttribute(6, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IReadOnlyList<WeatherForecast>>(
#nullable restore
#line 17 "D:\4.learn\BlazorApp\BlazorApp\Pages\FetchData.razor"
                          _forecasts

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.AddMarkupContent(9, "<th>Date</th>\r\n        ");
                __builder2.AddMarkupContent(10, "<th>Temp. (C)</th>\r\n        ");
                __builder2.AddMarkupContent(11, "<th>Temp. (F)</th>\r\n        ");
                __builder2.AddMarkupContent(12, "<th>Summary</th>\r\n        ");
            }
            ));
            __builder.AddAttribute(13, "Row", (Microsoft.AspNetCore.Components.RenderFragment<WeatherForecast>)((forecast) => (__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n            ");
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
                __builder2.AddMarkupContent(17, "\r\n            ");
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
                __builder2.AddMarkupContent(20, "\r\n            ");
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
                __builder2.AddMarkupContent(23, "\r\n            ");
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
                __builder2.AddMarkupContent(26, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.AddContent(28, "    ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "class", "btn btn-primary");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "D:\4.learn\BlazorApp\BlazorApp\Pages\FetchData.razor"
                                              AddNewForecasst

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "\r\n        Add New Forecast\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 37 "D:\4.learn\BlazorApp\BlazorApp\Pages\FetchData.razor"

    if (_showPopup)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "        ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "modal");
            __builder.AddAttribute(37, "style", "display:block");
            __builder.AddAttribute(38, "role", "dialog");
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "modal-dialog");
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "modal-content");
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "modal-header");
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "type", "button");
            __builder.AddAttribute(51, "class", "close");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "D:\4.learn\BlazorApp\BlazorApp\Pages\FetchData.razor"
                                                                      ClosePopup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(53, "\r\n                            ");
            __builder.AddMarkupContent(54, "<span area-hidden=\"true\">X</span>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "modal-body");
            __builder.AddMarkupContent(59, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(60);
            __builder.AddAttribute(61, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 49 "D:\4.learn\BlazorApp\BlazorApp\Pages\FetchData.razor"
                                         _addForecast

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 49 "D:\4.learn\BlazorApp\BlazorApp\Pages\FetchData.razor"
                                                                      SaveForecast

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(64, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(65);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(67);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\r\n                            ");
                __builder2.AddMarkupContent(69, "<label for=\"TemperatureC\">TemperatureC</label>\r\n                            ");
                __Blazor.BlazorApp.Pages.FetchData.TypeInference.CreateInputNumber_0(__builder2, 70, 71, "TemperatureC", 72, "form-control", 73, "TemperatureC", 74, 
#nullable restore
#line 55 "D:\4.learn\BlazorApp\BlazorApp\Pages\FetchData.razor"
                                                                                                                        _addForecast.TemperatureC

#line default
#line hidden
#nullable disable
                , 75, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _addForecast.TemperatureC = __value, _addForecast.TemperatureC)), 76, () => _addForecast.TemperatureC);
                __builder2.AddMarkupContent(77, "\r\n                            ");
                __builder2.AddMarkupContent(78, "<label for=\"Summary\">TemperatureC</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(79);
                __builder2.AddAttribute(80, "id", "Summary");
                __builder2.AddAttribute(81, "class", "form-control");
                __builder2.AddAttribute(82, "placeholder", "Summary");
                __builder2.AddAttribute(83, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "D:\4.learn\BlazorApp\BlazorApp\Pages\FetchData.razor"
                                                                                                             _addForecast.Summary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(84, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _addForecast.Summary = __value, _addForecast.Summary))));
                __builder2.AddAttribute(85, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _addForecast.Summary));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(86, "\r\n                            <br>\r\n                            ");
                __builder2.AddMarkupContent(87, "<button class=\"btn btn-primary\" type=\"submit\">Save</button>\r\n\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(88, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n");
#nullable restore
#line 66 "D:\4.learn\BlazorApp\BlazorApp\Pages\FetchData.razor"
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "D:\4.learn\BlazorApp\BlazorApp\Pages\FetchData.razor"
       
    private List<WeatherForecast> _forecasts;

    bool _showPopup = false;
    WeatherForecast _addForecast;

    protected override async Task OnInitializedAsync()
    {
        _forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

    void AddNewForecasst()
    {
        _showPopup = true;
        _addForecast = new WeatherForecast();
    }

    void SaveForecast()
    {
        _showPopup = false;
        _addForecast.Date = DateTime.Now;
        _forecasts.Add(_addForecast);
    }

    void ClosePopup()
    {
        _showPopup = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
namespace __Blazor.BlazorApp.Pages.FetchData
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
