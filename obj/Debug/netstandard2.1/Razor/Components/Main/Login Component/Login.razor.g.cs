#pragma checksum "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Login Component\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba320036fc3a03b36dc2dc2059071baca43fcdcf"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Components.Main.Login_Component
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : LoginComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex align-items-center position-relative height-lg-100vh");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "woocommerce");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row no-gutters");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-md-8 col-lg-7 col-xl-6 offset-md-2 offset-lg-2 offset-xl-3 space-3 space-lg-0");
            __builder.AddAttribute(14, "id", "customer_login");
            __builder.AddMarkupContent(15, "\r\n                    <div class=\"woocommerce-notices-wrapper\"></div>\r\n                    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "tab-content mt-5");
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "tab-pane active");
            __builder.AddAttribute(21, "id", "customer-login-form");
            __builder.AddAttribute(22, "aria-labelledby", "login-tab");
            __builder.AddMarkupContent(23, "\r\n                            ");
            __builder.AddMarkupContent(24, "<div class=\"mb-7\">\r\n                                <p style=\"font-size: 1.3rem; color:#ffffff !important; font-weight:bold;\">Login to manage your wallet.</p>\r\n                            </div>\r\n\r\n");
#nullable restore
#line 18 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Login Component\Login.razor"
                             if (!string.IsNullOrEmpty(ErrorMessage))
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "                                ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "alert alert-danger alert-dismissible bg-danger");
            __builder.AddAttribute(28, "role", "alert");
            __builder.AddAttribute(29, "style", "color: white; border-radius: 10px");
            __builder.AddMarkupContent(30, "\r\n                                    <i class=\"fa fa-times-circle\"></i> ");
            __builder.AddContent(31, 
#nullable restore
#line 22 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Login Component\Login.razor"
                                                                        ErrorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(32, "\r\n                                    ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "type", "button");
            __builder.AddAttribute(35, "class", "close");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Login Component\Login.razor"
                                                                                    () => {ErrorMessage = string.Empty;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(37, "\r\n                                        ");
            __builder.AddMarkupContent(38, "<span aria-hidden=\"true\">&times;</span>\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 27 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Login Component\Login.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 29 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Login Component\Login.razor"
                             if (!RequireTwoFactor)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(43);
            __builder.AddAttribute(44, "class", "login");
            __builder.AddAttribute(45, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 31 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Login Component\Login.razor"
                                                                LoginForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 31 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Login Component\Login.razor"
                                                                                           OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(48, "\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(49);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(51);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n                                    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group");
                __builder2.AddMarkupContent(55, "\r\n                                        ");
                __builder2.AddMarkupContent(56, "<label class=\"form-label text-light\" for=\"email\">Email Address</label>\r\n                                        ");
                __builder2.OpenElement(57, "input");
                __builder2.AddAttribute(58, "type", "email");
                __builder2.AddAttribute(59, "class", "form-control input-text");
                __builder2.AddAttribute(60, "name", "email");
                __builder2.AddAttribute(61, "autofocus", true);
                __builder2.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Login Component\Login.razor"
                                                      LoginForm.email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => LoginForm.email = __value, LoginForm.email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                                    ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "form-group");
                __builder2.AddMarkupContent(68, "\r\n                                        ");
                __builder2.OpenElement(69, "label");
                __builder2.AddAttribute(70, "class", "form-label");
                __builder2.AddAttribute(71, "for", "password");
                __builder2.AddMarkupContent(72, "\r\n                                            ");
                __builder2.OpenElement(73, "span");
                __builder2.AddAttribute(74, "class", "d-flex justify-content-between align-items-center text-light");
                __builder2.AddMarkupContent(75, "Password\r\n                                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(76);
                __builder2.AddAttribute(77, "class", "link-muted text-capitalize font-weight-normal");
                __builder2.AddAttribute(78, "href", "reset");
                __builder2.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(80, "\r\n                                                    Forgot Password?\r\n                                                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(81, "\r\n                                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                                        ");
                __builder2.OpenElement(84, "input");
                __builder2.AddAttribute(85, "class", "form-control input-text");
                __builder2.AddAttribute(86, "type", "password");
                __builder2.AddAttribute(87, "name", "password");
                __builder2.AddAttribute(88, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Login Component\Login.razor"
                                                       LoginForm.password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(89, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => LoginForm.password = __value, LoginForm.password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                                    ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "row align-items-center mb-5");
                __builder2.AddMarkupContent(94, "\r\n                                        ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "col-6");
                __builder2.AddMarkupContent(97, "\r\n                                            ");
                __builder2.AddMarkupContent(98, "<span class=\"small text-muted\">Don\'t have a wallet?</span>\r\n                                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(99);
                __builder2.AddAttribute(100, "class", "small login text-light");
                __builder2.AddAttribute(101, "href", "register");
                __builder2.AddAttribute(102, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(103, "\r\n                                                Create\r\n                                            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(104, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n                                        ");
                __builder2.AddMarkupContent(106, @"<div class=""col-6 text-right"">
                                            <button type=""submit"" class=""btn btn-light transition-3d-hover button"">
                                                Login
                                            </button>
                                        </div>
                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n                                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(108, "\r\n");
#nullable restore
#line 65 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Login Component\Login.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Login Component\Login.razor"
                             if (RequireTwoFactor)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(109, "                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(110);
            __builder.AddAttribute(111, "class", "login");
            __builder.AddAttribute(112, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 68 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Login Component\Login.razor"
                                                                TwoFactorForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(113, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 68 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Login Component\Login.razor"
                                                                                               ConfirmTwoFactor

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(114, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(115, "\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(116);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(117, "\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(118);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(119, "\r\n                                    ");
                __builder2.OpenElement(120, "div");
                __builder2.AddAttribute(121, "class", "form-group");
                __builder2.AddMarkupContent(122, "\r\n                                        ");
                __builder2.AddMarkupContent(123, "<label class=\"form-label text-light\" for=\"code\">Authentication Code</label>\r\n                                        ");
                __builder2.OpenElement(124, "input");
                __builder2.AddAttribute(125, "maxlength", "5");
                __builder2.AddAttribute(126, "placeholder", "Enter your authentication code");
                __builder2.AddAttribute(127, "type", "text");
                __builder2.AddAttribute(128, "class", "form-control input-text");
                __builder2.AddAttribute(129, "name", "code");
                __builder2.AddAttribute(130, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 73 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Login Component\Login.razor"
                                                                                                                 TwoFactorForm.Code

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(131, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TwoFactorForm.Code = __value, TwoFactorForm.Code));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\r\n                                    ");
                __builder2.OpenElement(134, "div");
                __builder2.AddAttribute(135, "class", "row align-items-center mb-5");
                __builder2.AddMarkupContent(136, "\r\n                                        ");
                __builder2.OpenElement(137, "div");
                __builder2.AddAttribute(138, "class", "col-6");
                __builder2.AddMarkupContent(139, "\r\n                                            ");
                __builder2.AddMarkupContent(140, "<span style=\"color: #ffffff !important\" class=\"small text-muted\">Don\'t have a wallet?</span>\r\n                                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(141);
                __builder2.AddAttribute(142, "class", "small login text-light");
                __builder2.AddAttribute(143, "href", "register");
                __builder2.AddAttribute(144, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(145, "\r\n                                                Create\r\n                                            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(146, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(147, "\r\n                                        ");
                __builder2.AddMarkupContent(148, @"<div class=""col-6 text-right"">
                                            <button type=""submit"" class=""btn btn-light transition-3d-hover button"">
                                                Submit
                                            </button>
                                        </div>
                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(149, "\r\n                                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(150, "\r\n");
#nullable restore
#line 90 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Login Component\Login.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(151, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591