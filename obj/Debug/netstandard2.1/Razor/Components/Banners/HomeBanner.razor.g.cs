#pragma checksum "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Banners\HomeBanner.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8336f9a25bd0c68f02081ee8d8f682716a12e58b"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Components.Banners
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
    public partial class HomeBanner : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "offset-md-2 col-md-8");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "banner-content");
            __builder.AddMarkupContent(8, "\r\n            <h2></h2>\r\n            ");
            __builder.AddMarkupContent(9, "<p style=\"margin-top: 6rem;\">\r\n                The worlds leading crypto wallet trusted by millions of users\r\n            </p>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(10);
            __builder.AddAttribute(11, "class", "btn btn-light");
            __builder.AddAttribute(12, "href", "register");
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n                Get Started Now\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.AddMarkupContent(19, @"<div class=""container-fluid"" style=""padding-left: 0 !important; padding-right:0 !important;"">
    <div style=""height:62px; background-color: #1D2330; overflow:hidden; box-sizing: border-box; border: 1px solid #282E3B; border-radius: 4px; text-align: right; line-height:14px; block-size:62px; font-size: 12px; font-feature-settings: normal; text-size-adjust: 100%; box-shadow: inset 0 -20px 0 0 #262B38;padding:1px;padding: 0px; margin: 0px; width: 100%;"">
        <div style=""height:40px; padding:0px; margin:0px; width: 100%;""><iframe src=""https://widget.coinlib.io/widget?type=horizontal_v2&theme=dark&pref_coin_id=1505&invert_hover=no"" width=""100%"" height=""36px"" scrolling=""auto"" marginwidth=""0"" marginheight=""0"" frameborder=""0"" border=""0"" style=""border:0;margin:0;padding:0;""></iframe></div>
        <div style=""color: #626B7F; line-height: 14px; font-weight: 400; font-size: 11px; box-sizing: border-box; padding: 2px 6px; width: 100%; font-family: Verdana, Tahoma, Arial, sans-serif;"">
            <a href=""https://coinlib.io"" target=""_blank"" style=""font-weight: 500; color: #626B7F; text-decoration:none; font-size:11px"">Cryptocurrency
                Prices</a>&nbsp;by Coinlib
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
