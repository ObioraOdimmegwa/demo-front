#pragma checksum "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Settings\Settings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbcbdbc2a973924fb479a59d5b8a88cdd10ba2ea"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Components.Wallet.Settings
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
    public partial class Settings : SettingsComponent
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
            __builder.AddAttribute(10, "class", "nk-block-head");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "nk-block-head-content");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.AddMarkupContent(15, "<div class=\"nk-block-head-sub\"><span>Wallet Setting</span></div>\r\n                    ");
            __builder.OpenElement(16, "h2");
            __builder.AddAttribute(17, "class", "nk-block-title fw-normal");
            __builder.AddContent(18, 
#nullable restore
#line 10 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Settings\Settings.razor"
                                                          Header

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.AddMarkupContent(20, "<div class=\"nk-block-des\">\r\n                        <p>You have full control to manage your own wallet setting. <span class=\"text-primary\"><em class=\"icon ni ni-info\"></em></span></p>\r\n                    </div>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "ul");
            __builder.AddAttribute(24, "class", "nk-nav nav nav-tabs");
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "li");
            __builder.AddAttribute(27, "class", "nav-item" + " " + (
#nullable restore
#line 18 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Settings\Settings.razor"
                                      _component == "profile" ? "active" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(29);
            __builder.AddAttribute(30, "class", "nav-link");
            __builder.AddAttribute(31, "href", "/settings/profile");
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(33, "\r\n                        Personal\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "li");
            __builder.AddAttribute(37, "class", "nav-item" + " " + (
#nullable restore
#line 23 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Settings\Settings.razor"
                                      _component == "security" ? "active" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(39);
            __builder.AddAttribute(40, "class", "nav-link");
            __builder.AddAttribute(41, "href", "/settings/password");
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(43, "\r\n                        Security\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "li");
            __builder.AddAttribute(47, "class", "nav-item" + " " + (
#nullable restore
#line 28 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Settings\Settings.razor"
                                      _component == "preference" ? "active" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(49);
            __builder.AddAttribute(50, "class", "nav-link");
            __builder.AddAttribute(51, "href", "/settings/preference");
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(53, "\r\n                        Preference\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            \r\n");
#nullable restore
#line 35 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Settings\Settings.razor"
             if(_component == "profile")
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "                ");
            __builder.OpenComponent<Client.Components.Wallet.Settings.ProfileSettings>(58);
            __builder.CloseComponent();
            __builder.AddMarkupContent(59, "\r\n");
#nullable restore
#line 38 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Settings\Settings.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Settings\Settings.razor"
             if(_component == "security")
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "                ");
            __builder.OpenComponent<Client.Components.Wallet.Settings.SecuritySettings>(61);
            __builder.CloseComponent();
            __builder.AddMarkupContent(62, "\r\n");
#nullable restore
#line 42 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Settings\Settings.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Settings\Settings.razor"
             if(_component == "preference")
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(63, "                ");
            __builder.OpenComponent<Client.Components.Wallet.Settings.PreferenceSettings>(64);
            __builder.CloseComponent();
            __builder.AddMarkupContent(65, "\r\n");
#nullable restore
#line 46 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Wallet\Settings\Settings.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(66, "            \r\n            \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591