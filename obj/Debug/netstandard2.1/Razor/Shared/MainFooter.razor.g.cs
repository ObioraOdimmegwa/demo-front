#pragma checksum "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Shared\MainFooter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bd2355dd322e19edb991a8306af5980301f5e52"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Shared
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
#nullable restore
#line 1 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Shared\MainFooter.razor"
using Client.Components;

#line default
#line hidden
#nullable disable
    public partial class MainFooter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "colto-section");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", true);
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, "<div class=\"colto-content\">\r\n                <h3>Getting started</h3>\r\n                <p>Powerful crypto asset management tools readily available for use</p>\r\n            </div>\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "colto-btn-group");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(13);
            __builder.AddAttribute(14, "class", "btn callto-btn");
            __builder.AddAttribute(15, "href", "login");
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(17, "\r\n                    Log In\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.AddMarkupContent(19, "<span>or</span>\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "btn callto-btn");
            __builder.AddAttribute(22, "href", "register");
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(24, "\r\n                    Create Wallet\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n");
            __builder.OpenElement(30, "footer");
            __builder.AddAttribute(31, "class", "footer");
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "footer-upper-section");
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "container");
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "row");
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "col-lg-3 col-md-4");
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "footer-logo");
            __builder.AddMarkupContent(47, "\r\n                        ");
            __builder.OpenElement(48, "a");
            __builder.AddAttribute(49, "href", true);
            __builder.AddMarkupContent(50, "\r\n                            ");
            __builder.OpenComponent<Client.Components.Logo>(51);
            __builder.CloseComponent();
            __builder.AddMarkupContent(52, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "col-lg-2 col-md-4");
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "footer-info-list");
            __builder.AddMarkupContent(61, "\r\n                        ");
            __builder.AddMarkupContent(62, "<h4>Company</h4>\r\n                        ");
            __builder.OpenElement(63, "ul");
            __builder.AddMarkupContent(64, "\r\n                            ");
            __builder.OpenElement(65, "li");
            __builder.AddAttribute(66, "class", "nav-item");
            __builder.AddMarkupContent(67, "\r\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(68);
            __builder.AddAttribute(69, "class", "nav-link");
            __builder.AddAttribute(70, "href", "about");
            __builder.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(72, "\r\n                                    About\r\n                                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(73, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                            ");
            __builder.OpenElement(75, "li");
            __builder.AddAttribute(76, "class", "nav-item");
            __builder.AddMarkupContent(77, "\r\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(78);
            __builder.AddAttribute(79, "class", "nav-link");
            __builder.AddAttribute(80, "href", "services");
            __builder.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(82, "\r\n                                    Services\r\n                                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(83, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                            ");
            __builder.OpenElement(85, "li");
            __builder.AddAttribute(86, "class", "nav-item");
            __builder.AddMarkupContent(87, "\r\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(88);
            __builder.AddAttribute(89, "class", "nav-link");
            __builder.AddAttribute(90, "href", "contact");
            __builder.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(92, "\r\n                                    Contact Us\r\n                                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(93, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                            ");
            __builder.OpenElement(95, "li");
            __builder.AddAttribute(96, "class", "nav-item");
            __builder.AddMarkupContent(97, "\r\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(98);
            __builder.AddAttribute(99, "class", "nav-link");
            __builder.AddAttribute(100, "href", "wallet");
            __builder.AddAttribute(101, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(102, "\r\n                                    Wallet\r\n                                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(103, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                ");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "col-lg-2 col-md-4");
            __builder.AddMarkupContent(110, "\r\n                    ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "footer-info-list");
            __builder.AddMarkupContent(113, "\r\n                        ");
            __builder.AddMarkupContent(114, "<h4>Learn</h4>\r\n                        ");
            __builder.OpenElement(115, "ul");
            __builder.AddMarkupContent(116, "\r\n                            ");
            __builder.OpenElement(117, "li");
            __builder.AddAttribute(118, "class", "nav-item");
            __builder.AddMarkupContent(119, "\r\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(120);
            __builder.AddAttribute(121, "class", "nav-link");
            __builder.AddAttribute(122, "href", "faq");
            __builder.AddAttribute(123, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(124, "\r\n                                    Faq\r\n                                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(125, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                            ");
            __builder.OpenElement(127, "li");
            __builder.AddAttribute(128, "class", "nav-item");
            __builder.AddMarkupContent(129, "\r\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(130);
            __builder.AddAttribute(131, "class", "nav-link");
            __builder.AddAttribute(132, "href", "careers");
            __builder.AddAttribute(133, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(134, "\r\n                                    Careers\r\n                                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(135, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                            ");
            __builder.OpenElement(137, "li");
            __builder.AddAttribute(138, "class", "nav-item");
            __builder.AddMarkupContent(139, "\r\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(140);
            __builder.AddAttribute(141, "class", "nav-link");
            __builder.AddAttribute(142, "href", "terms");
            __builder.AddAttribute(143, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(144, "\r\n                                    Terms\r\n                                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(145, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n                            ");
            __builder.OpenElement(147, "li");
            __builder.AddAttribute(148, "class", "nav-item");
            __builder.AddMarkupContent(149, "\r\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(150);
            __builder.AddAttribute(151, "class", "nav-link");
            __builder.AddAttribute(152, "href", "privacy");
            __builder.AddAttribute(153, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(154, "\r\n                                    Privacy\r\n                                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(155, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n                ");
            __builder.AddMarkupContent(160, @"<div class=""col-lg-2 col-md-4"">
                    <div class=""footer-info-list"">
                        <h4>Contact</h4>
                        <ul class=""contact-info"">
                            <li>Email: <span><a href=""mailto: support@finlexiswallet.com"" class=""__cf_email__"" data-cfemail=""bed7d0d8d190dbc6ddd1d7d0fed9d3dfd7d290ddd1d3"">[email&#160;protected]</a></span>
                            </li>
                            <li>
                                <div id=""google_translate_element""></div>
                            </li>
                        </ul>
                    </div>
                </div>
            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\r\n    ");
            __builder.AddMarkupContent(164, @"<div class=""footer-bottom"">
        <div class=""container"">
            <div class=""footer-bottom-wrap"">
                <div class=""copyright-text"">
                    ?? 2018 <a href=""#"">Finlexis</a>. All Rights Reserved
                </div>
            </div>
        </div>
    </div>
");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
