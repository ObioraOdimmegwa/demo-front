#pragma checksum "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Send\SendCryptoPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1253063e35aacf62e28e0fc71c0590c93c967610"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Components.Wallet.Send
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
    public partial class SendCryptoPage : SendCrptoPageComponent
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
            __builder.AddAttribute(19, "class", "nav-item");
            __builder.AddMarkupContent(20, "\r\n                            ");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "class", "nav-link");
            __builder.AddAttribute(23, "href", "/receive/" + (
#nullable restore
#line 11 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Send\SendCryptoPage.razor"
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
            __builder.AddAttribute(28, "class", "nav-item active");
            __builder.AddMarkupContent(29, "\r\n                            ");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "class", "nav-link");
            __builder.AddAttribute(32, "href", "/send/" + (
#nullable restore
#line 14 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Send\SendCryptoPage.razor"
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
#line 19 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Send\SendCryptoPage.razor"
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
            __builder.AddContent(47, "Send ");
            __builder.AddContent(48, 
#nullable restore
#line 20 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Send\SendCryptoPage.razor"
                                            crypto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "buysell-block");
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(54);
            __builder.AddAttribute(55, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 23 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Send\SendCryptoPage.razor"
                                      SendForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "class", "currency_validate");
            __builder.AddAttribute(57, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 23 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Send\SendCryptoPage.razor"
                                                                                          Send

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(59, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(60);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(62);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\r\n");
#nullable restore
#line 26 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Send\SendCryptoPage.razor"
                         if (!string.IsNullOrEmpty(ErrorMessage))
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(64, "                            ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "alert alert-danger alert-dismissible bg-danger");
                __builder2.AddAttribute(67, "role", "alert");
                __builder2.AddAttribute(68, "style", "color: white; border-radius: 10px");
                __builder2.AddMarkupContent(69, "\r\n                                <i class=\"fa fa-times-circle\"></i> ");
                __builder2.AddContent(70, 
#nullable restore
#line 30 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Send\SendCryptoPage.razor"
                                                                    ErrorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(71, "\r\n                                ");
                __builder2.OpenElement(72, "button");
                __builder2.AddAttribute(73, "type", "button");
                __builder2.AddAttribute(74, "class", "close");
                __builder2.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Send\SendCryptoPage.razor"
                                                                                () => {ErrorMessage = string.Empty;}

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(76, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n");
#nullable restore
#line 35 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Send\SendCryptoPage.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(79, "                        ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "form-group");
                __builder2.AddMarkupContent(82, "\r\n                            ");
                __builder2.AddMarkupContent(83, "<p>Wallet Address</p>\r\n                            ");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "input-group");
                __builder2.AddMarkupContent(86, "\r\n                                ");
                __builder2.OpenElement(87, "input");
                __builder2.AddAttribute(88, "type", "text");
                __builder2.AddAttribute(89, "name", "Address");
                __builder2.AddAttribute(90, "style", "height: 50px");
                __builder2.AddAttribute(91, "class", "form-control");
                __builder2.AddAttribute(92, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Send\SendCryptoPage.razor"
                                               SendForm.Address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(93, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SendForm.Address = __value, SendForm.Address));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n                        ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "form-group");
                __builder2.AddMarkupContent(99, "\r\n                            ");
                __builder2.AddMarkupContent(100, "<p>Amount</p>\r\n                            ");
                __builder2.OpenElement(101, "div");
                __builder2.AddAttribute(102, "class", "input-group");
                __builder2.AddMarkupContent(103, "\r\n                                ");
                __builder2.OpenElement(104, "input");
                __builder2.AddAttribute(105, "type", "number");
                __builder2.AddAttribute(106, "name", "Amount");
                __builder2.AddAttribute(107, "style", "height: 50px");
                __builder2.AddAttribute(108, "class", "form-control");
                __builder2.AddAttribute(109, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Send\SendCryptoPage.razor"
                                               SendForm.Amount

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(110, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SendForm.Amount = __value, SendForm.Amount, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n                        ");
                __builder2.OpenElement(114, "div");
                __builder2.AddAttribute(115, "class", "form-group");
                __builder2.AddMarkupContent(116, "\r\n                            ");
                __builder2.AddMarkupContent(117, "<p>Password</p>\r\n                            ");
                __builder2.OpenElement(118, "div");
                __builder2.AddAttribute(119, "class", "input-group");
                __builder2.AddMarkupContent(120, "\r\n                                ");
                __builder2.OpenElement(121, "input");
                __builder2.AddAttribute(122, "type", "password");
                __builder2.AddAttribute(123, "name", "Password");
                __builder2.AddAttribute(124, "style", "height: 50px");
                __builder2.AddAttribute(125, "class", "form-control");
                __builder2.AddAttribute(126, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 53 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Send\SendCryptoPage.razor"
                                               SendForm.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(127, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SendForm.Password = __value, SendForm.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n                            ");
                __builder2.AddMarkupContent(130, "<p>Verify that it is you <span class=\"text-primary\"><em class=\"icon ni ni-info\"></em></span>\r\n                            </p>\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(131, "\r\n                        ");
                __builder2.AddMarkupContent(132, "<button type=\"submit\" class=\"btn btn-primary btn-lg\">\r\n                            Send\r\n                        </button>\r\n\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(133, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
