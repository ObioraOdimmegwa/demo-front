#pragma checksum "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Transactions\Transactions.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c967cc3dad6f49b02af95c8569b719242761bb9"
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
    public partial class Transactions : TransactionsComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"nk-content nk-content-fluid\">\r\n    <div class=\"container-xl wide-lg\">\r\n        <div class=\"nk-content-body\">\r\n            <div class=\"nk-block-head\">\r\n                <div class=\"nk-block-between-md g-4\">\r\n                    <div class=\"nk-block-head-content\">\r\n                        <h2 class=\"nk-block-title fw-normal\">Your Transactions</h2>\r\n                        <div class=\"nk-block-des\">\r\n                            <p>See full list of transactions that occurred in your Finlexis wallet <span class=\"text-primary\"><em class=\"icon ni ni-info\"></em></span></p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <ul class=\"nk-nav nav nav-tabs\">\r\n                <li class=\"nav-item\">\r\n                    <a class=\"nav-link\">Transaction History</a>\r\n                </li>\r\n            </ul>\r\n            <div class=\"nk-block nk-block-sm\">\r\n                <div class=\"tranx-list tranx-list-stretch card card-bordered\">\r\n                    <div class=\"card\">\r\n                        <div class=\"card-inner card-inner-lg\">\r\n                            <div class=\"align-center flex-wrap flex-md-nowrap g-4\">\r\n                                <div class=\"nk-block-image w-120px flex-shrink-0\">\r\n                                    <svg xmlns=\"http://www.w3.org/2000/svg\" viewBox=\"0 0 120 118\">\r\n                                        <path d=\"M8.916,94.745C-.318,79.153-2.164,58.569,2.382,40.578,7.155,21.69,19.045,9.451,35.162,4.32,46.609.676,58.716.331,70.456,1.845,84.683,3.68,99.57,8.694,108.892,21.408c10.03,13.679,12.071,34.71,10.747,52.054-1.173,15.359-7.441,27.489-19.231,34.494-10.689,6.351-22.92,8.733-34.715,10.331-16.181,2.192-34.195-.336-47.6-12.281A47.243,47.243,0,0,1,8.916,94.745Z\" transform=\"translate(0 -1)\" fill=\"#f6faff\"></path>\r\n                                        <rect x=\"18\" y=\"32\" width=\"84\" height=\"50\" rx=\"4\" ry=\"4\" fill=\"#fff\"></rect>\r\n                                        <rect x=\"26\" y=\"44\" width=\"20\" height=\"12\" rx=\"1\" ry=\"1\" fill=\"#e5effe\"></rect>\r\n                                        <rect x=\"50\" y=\"44\" width=\"20\" height=\"12\" rx=\"1\" ry=\"1\" fill=\"#e5effe\"></rect>\r\n                                        <rect x=\"74\" y=\"44\" width=\"20\" height=\"12\" rx=\"1\" ry=\"1\" fill=\"#e5effe\"></rect>\r\n                                        <rect x=\"38\" y=\"60\" width=\"20\" height=\"12\" rx=\"1\" ry=\"1\" fill=\"#e5effe\"></rect>\r\n                                        <rect x=\"62\" y=\"60\" width=\"20\" height=\"12\" rx=\"1\" ry=\"1\" fill=\"#e5effe\"></rect>\r\n                                        <path d=\"M98,32H22a5.006,5.006,0,0,0-5,5V79a5.006,5.006,0,0,0,5,5H52v8H45a2,2,0,0,0-2,2v4a2,2,0,0,0,2,2H73a2,2,0,0,0,2-2V94a2,2,0,0,0-2-2H66V84H98a5.006,5.006,0,0,0,5-5V37A5.006,5.006,0,0,0,98,32ZM73,94v4H45V94Zm-9-2H54V84H64Zm37-13a3,3,0,0,1-3,3H22a3,3,0,0,1-3-3V37a3,3,0,0,1,3-3H98a3,3,0,0,1,3,3Z\" transform=\"translate(0 -1)\" fill=\"#798bff\"></path>\r\n                                        <path d=\"M61.444,41H40.111L33,48.143V19.7A3.632,3.632,0,0,1,36.556,16H61.444A3.632,3.632,0,0,1,65,19.7V37.3A3.632,3.632,0,0,1,61.444,41Z\" transform=\"translate(0 -1)\" fill=\"#6576ff\"></path>\r\n                                        <path d=\"M61.444,41H40.111L33,48.143V19.7A3.632,3.632,0,0,1,36.556,16H61.444A3.632,3.632,0,0,1,65,19.7V37.3A3.632,3.632,0,0,1,61.444,41Z\" transform=\"translate(0 -1)\" fill=\"none\" stroke=\"#6576ff\" stroke-miterlimit=\"10\" stroke-width=\"2\"></path>\r\n                                        <line x1=\"40\" y1=\"22\" x2=\"57\" y2=\"22\" fill=\"none\" stroke=\"#fffffe\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\"></line>\r\n                                        <line x1=\"40\" y1=\"27\" x2=\"57\" y2=\"27\" fill=\"none\" stroke=\"#fffffe\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\"></line>\r\n                                        <line x1=\"40\" y1=\"32\" x2=\"50\" y2=\"32\" fill=\"none\" stroke=\"#fffffe\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\"></line>\r\n                                        <line x1=\"30.5\" y1=\"87.5\" x2=\"30.5\" y2=\"91.5\" fill=\"none\" stroke=\"#9cabff\" stroke-linecap=\"round\" stroke-linejoin=\"round\"></line>\r\n                                        <line x1=\"28.5\" y1=\"89.5\" x2=\"32.5\" y2=\"89.5\" fill=\"none\" stroke=\"#9cabff\" stroke-linecap=\"round\" stroke-linejoin=\"round\"></line>\r\n                                        <line x1=\"79.5\" y1=\"22.5\" x2=\"79.5\" y2=\"26.5\" fill=\"none\" stroke=\"#9cabff\" stroke-linecap=\"round\" stroke-linejoin=\"round\"></line>\r\n                                        <line x1=\"77.5\" y1=\"24.5\" x2=\"81.5\" y2=\"24.5\" fill=\"none\" stroke=\"#9cabff\" stroke-linecap=\"round\" stroke-linejoin=\"round\"></line>\r\n                                        <circle cx=\"90.5\" cy=\"97.5\" r=\"3\" fill=\"none\" stroke=\"#9cabff\" stroke-miterlimit=\"10\"></circle>\r\n                                        <circle cx=\"24\" cy=\"23\" r=\"2.5\" fill=\"none\" stroke=\"#9cabff\" stroke-miterlimit=\"10\"></circle>\r\n                                    </svg>\r\n                                </div>\r\n\r\n                                <div class=\"nk-block-content\">\r\n                                    <div class=\"nk-block-content-head px-lg-4\">\r\n                                        <h5>Ops! You have no transaction yet.</h5>\r\n                                        <p class=\"text-soft\">To transfer crypto into your Finlexis wallet, click the\r\n                                            receive button. Proceed by selecting crypto you which to receive.</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
