#pragma checksum "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Receive\ReceiveCryptoPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9b0a64b9b18478981a1c05581e8058d3cb01126"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Components.Wallet.Receive
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    public partial class ReceiveCryptoPage : ReceiveCryptoPageComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "nk-content nk-content-fluid");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-xl wide-lg");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "nk-content-body");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "buysell wide-xs m-auto");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "buysell-nav text-center");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "ul");
            __builder.AddAttribute(16, "class", "nk-nav nav nav-tabs nav-tabs-s2");
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "li");
            __builder.AddAttribute(19, "class", "nav-item active");
            __builder.AddMarkupContent(20, "\r\n                            ");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "class", "nav-link");
            __builder.AddAttribute(23, "href", "/receive/" + (
#nullable restore
#line 11 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Receive\ReceiveCryptoPage.razor"
                                                                crypto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "Receive");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "nav-item");
            __builder.AddMarkupContent(29, "\r\n                            ");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "class", "nav-link");
            __builder.AddAttribute(32, "href", "/send/" + (
#nullable restore
#line 14 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Receive\ReceiveCryptoPage.razor"
                                                             crypto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "Send");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "buysell-title text-center");
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "img");
            __builder.AddAttribute(42, "src", "images/" + (
#nullable restore
#line 19 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Receive\ReceiveCryptoPage.razor"
                                      GetCoinIcon()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "style", "height: 50px; width: 50px;");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.OpenElement(45, "h2");
            __builder.AddAttribute(46, "class", "title");
            __builder.AddContent(47, "Receive ");
            __builder.AddContent(48, 
#nullable restore
#line 20 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Receive\ReceiveCryptoPage.razor"
                                               crypto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(51);
            __builder.AddAttribute(52, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 22 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Receive\ReceiveCryptoPage.razor"
                                  ReceiveForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 22 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Receive\ReceiveCryptoPage.razor"
                                                               GenerateAddress

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(55, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(56);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(58);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\r\n                    ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "buysell-block");
                __builder2.AddMarkupContent(62, "\r\n                        ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "form-group");
                __builder2.AddMarkupContent(65, "\r\n                            ");
                __builder2.AddMarkupContent(66, "<p>Choose Currency</p>\r\n                            ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "input-group mb-3");
                __builder2.AddMarkupContent(69, "\r\n                                ");
                __builder2.OpenElement(70, "select");
                __builder2.AddAttribute(71, "name", "Currency");
                __builder2.AddAttribute(72, "style", "height: 50px");
                __builder2.AddAttribute(73, "class", "form-control");
                __builder2.AddAttribute(74, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Receive\ReceiveCryptoPage.razor"
                                                ReceiveForm.Currency

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ReceiveForm.Currency = __value, ReceiveForm.Currency));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(76, "\r\n");
#nullable restore
#line 30 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Receive\ReceiveCryptoPage.razor"
                                     foreach (string curr in Currencies.List)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(77, "                                        ");
                __builder2.OpenElement(78, "option");
                __builder2.AddAttribute(79, "value", 
#nullable restore
#line 32 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Receive\ReceiveCryptoPage.razor"
                                                        curr

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(80, 
#nullable restore
#line 32 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Receive\ReceiveCryptoPage.razor"
                                                               curr

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n");
#nullable restore
#line 33 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Receive\ReceiveCryptoPage.razor"
                                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(82, "                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n                        ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "form-group");
                __builder2.AddMarkupContent(88, "\r\n                            ");
                __builder2.AddMarkupContent(89, "<p>Amount</p>\r\n                            ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "input-group");
                __builder2.AddMarkupContent(92, "\r\n                                ");
                __builder2.OpenElement(93, "input");
                __builder2.AddAttribute(94, "type", "number");
                __builder2.AddAttribute(95, "name", "Amount");
                __builder2.AddAttribute(96, "style", "height: 50px");
                __builder2.AddAttribute(97, "class", "form-control");
                __builder2.AddAttribute(98, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Receive\ReceiveCryptoPage.razor"
                                               ReceiveForm.Amount

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(99, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ReceiveForm.Amount = __value, ReceiveForm.Amount, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n                        ");
                __builder2.AddMarkupContent(103, "<button type=\"submit\" class=\"btn btn-primary btn-lg\">\r\n                            Generate Unique Address\r\n                        </button>\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(105, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
