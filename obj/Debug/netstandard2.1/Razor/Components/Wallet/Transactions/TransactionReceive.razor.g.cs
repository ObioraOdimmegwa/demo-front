#pragma checksum "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Transactions\TransactionReceive.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f543597c7ca457d4479ba4791580f1e47d29d761"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Components.Wallet.Transactions
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
    public partial class TransactionReceive : TransactionReceiveComponent
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
            __builder.AddMarkupContent(11, "\r\n                \r\n                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "buysell-title text-center");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "img");
            __builder.AddAttribute(16, "src", "images/" + (
#nullable restore
#line 10 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Transactions\TransactionReceive.razor"
                                       CoinIcon

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "style", "height: 50px; width: 50px;");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.AddMarkupContent(19, "<h2 class=\"title\">Transaction Details</h2>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "buysell-block");
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "row");
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-sm-6");
            __builder.AddMarkupContent(29, "\r\n                            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "identity-content");
            __builder.AddMarkupContent(32, "\r\n                                ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "form-group");
            __builder.AddMarkupContent(35, "\r\n                                    ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "input-group");
            __builder.AddMarkupContent(38, "\r\n                                        ");
            __builder.OpenElement(39, "img");
            __builder.AddAttribute(40, "width", "100%");
            __builder.AddAttribute(41, "height", "270px");
            __builder.AddAttribute(42, "src", "https://chart.googleapis.com/chart?chs=250x250&cht=qr&chl=" + (
#nullable restore
#line 20 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Transactions\TransactionReceive.razor"
                                                                                                             Coin

#line default
#line hidden
#nullable disable
            ) + ":" + (
#nullable restore
#line 20 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Transactions\TransactionReceive.razor"
                                                                                                                     Address

#line default
#line hidden
#nullable disable
            ) + "?amount=" + (
#nullable restore
#line 20 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Transactions\TransactionReceive.razor"
                                                                                                                                       Amount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "alt", 
#nullable restore
#line 21 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Transactions\TransactionReceive.razor"
                                                  Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "col-sm-6");
            __builder.AddMarkupContent(51, "\r\n                            ");
            __builder.OpenElement(52, "form");
            __builder.AddAttribute(53, "class", "currency_validate");
            __builder.AddMarkupContent(54, "\r\n                                ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "form-group");
            __builder.AddMarkupContent(57, "\r\n                                    <label class=\"mr-sm-2\"></label>\r\n                                    ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "input-group");
            __builder.AddMarkupContent(60, "\r\n                                        ");
            __builder.OpenElement(61, "input");
            __builder.AddAttribute(62, "class", "form-control js-copytextarea");
            __builder.AddAttribute(63, "style", "width:90%; border: 1px solid #fff;");
            __builder.AddAttribute(64, "value", 
#nullable restore
#line 33 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Transactions\TransactionReceive.razor"
                                                    Address

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(65, "readonly", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                                    <br>\r\n                                    ");
            __builder.OpenElement(68, "p");
            __builder.AddContent(69, "We strongly advise that you send exactly ");
            __builder.OpenElement(70, "b");
            __builder.AddContent(71, 
#nullable restore
#line 36 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Transactions\TransactionReceive.razor"
                                                                                    Transaction.Amount.ToMoneyFormat()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(72, " ");
            __builder.AddContent(73, 
#nullable restore
#line 36 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Transactions\TransactionReceive.razor"
                                                                                                                        Transaction.Currency

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, " to your generated wallet\r\n                                        address for faster blockchain confirmation.");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n\r\n                                ");
            __builder.AddMarkupContent(77, @"<div class=""form-group"">
                                    <button type=""button"" class=""btn btn-primary btn-block js-textareacopybtn"">
                                        Copy Your Address
                                    </button>
                                </div>
                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                        ");
            __builder.AddMarkupContent(80, @"<div class=""col-sm-12"">
                            <form action=""#"" class=""identity-upload"">
                                <div class=""identity-content"">
                                    <br><br>
                                    <h5>Finding it difficult to purchase bitcoin?</h5>
                                    <p>Copy your generated wallet address and visit either of these platforms to
                                        purchase bitcoin and store in your Finlexis Wallet</p>
                                    <a href=""https://www.coinmama.com/"" style=""text-decoration: underline""><b>Coinmama.com</b></a><br>
                                    <a href=""https://crypto.com/en/index.html"" style=""text-decoration: underline""><b>Crypto.com</b></a><br>
                                    <a href=""https://www.luno.com/en/"" style=""text-decoration: underline""><b>Luno.com</b></a><br>

                                    <br>
                                    <p>After successful purchase, transfer bitcoin to your Finlexis Wallet via your
                                        generated wallet address</p>
                                </div>
                            </form>
                        </div>
                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
