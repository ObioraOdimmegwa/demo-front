#pragma checksum "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Register Component\CompleteRegistration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b45f37ca1dad7618ca8e7c76143f2ec3ebee549b"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Components.Main.Register_Component
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/complete-registration")]
    public partial class CompleteRegistration : CompleteRegistrationComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "d-flex align-items-center position-relative height-lg-100vh");
                __builder2.AddMarkupContent(5, "\r\n            ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "container");
                __builder2.AddMarkupContent(8, "\r\n                ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "woocommerce");
                __builder2.AddMarkupContent(11, "\r\n                    ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "row no-gutters");
                __builder2.AddMarkupContent(14, "\r\n                        ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "col-md-8 col-lg-7 col-xl-6 offset-md-2 offset-lg-2 offset-xl-3 space-3 space-lg-0");
                __builder2.AddAttribute(17, "id", "customer_login");
                __builder2.AddMarkupContent(18, "\r\n                            <div class=\"woocommerce-notices-wrapper\"></div>\r\n                            ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "tab-content mt-5");
                __builder2.AddMarkupContent(21, "\r\n                                ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "tab-pane active");
                __builder2.AddAttribute(24, "id", "customer-register-form");
                __builder2.AddAttribute(25, "aria-labelledby", "register-tab");
                __builder2.AddMarkupContent(26, "\r\n                                    ");
                __builder2.AddMarkupContent(27, "<div class=\"mb-7\">\r\n                                        <p style=\"font-size: 1.3rem; color:#ffffff !important;\">Your username is how\r\n                                            we\'ll identify you.</p>\r\n                                    </div>\r\n");
#nullable restore
#line 19 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Register Component\CompleteRegistration.razor"
                                     if (!string.IsNullOrEmpty(ErrorMessage))
                                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(28, "                                        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "alert alert-danger alert-dismissible bg-danger");
                __builder2.AddAttribute(31, "role", "alert");
                __builder2.AddAttribute(32, "style", "color: white; border-radius: 10px");
                __builder2.AddMarkupContent(33, "\r\n                                            <i class=\"fa fa-times-circle\"></i> ");
                __builder2.AddContent(34, 
#nullable restore
#line 23 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Register Component\CompleteRegistration.razor"
                                                                                ErrorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(35, "\r\n                                            ");
                __builder2.OpenElement(36, "button");
                __builder2.AddAttribute(37, "type", "button");
                __builder2.AddAttribute(38, "class", "close");
                __builder2.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Register Component\CompleteRegistration.razor"
                                                        () => {ErrorMessage = string.Empty;}

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(40, "\r\n                                                ");
                __builder2.AddMarkupContent(41, "<span aria-hidden=\"true\">&times;</span>\r\n                                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n");
#nullable restore
#line 29 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Register Component\CompleteRegistration.razor"
                                    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(44, "\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(45);
                __builder2.AddAttribute(46, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 31 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Register Component\CompleteRegistration.razor"
                                                                               CompleteSignUpForm

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "class", "register");
                __builder2.AddAttribute(48, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 32 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Register Component\CompleteRegistration.razor"
                                                        OnValidSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((AnotherContext) => (__builder3) => {
                    __builder3.AddMarkupContent(50, "\r\n                                        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(51);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\r\n                                        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(53);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\r\n                                        ");
                    __builder3.OpenElement(55, "div");
                    __builder3.AddAttribute(56, "class", "form-group");
                    __builder3.AddMarkupContent(57, "\r\n                                            ");
                    __builder3.AddMarkupContent(58, "<label class=\"form-label text-light\" for=\"username\">Username</label>\r\n                                            ");
                    __builder3.OpenElement(59, "input");
                    __builder3.AddAttribute(60, "maxlength", "50");
                    __builder3.AddAttribute(61, "type", "text");
                    __builder3.AddAttribute(62, "class", "form-control input-text");
                    __builder3.AddAttribute(63, "name", "username");
                    __builder3.AddAttribute(64, "id", "username");
                    __builder3.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Register Component\CompleteRegistration.razor"
                                                           CompleteSignUpForm.username

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CompleteSignUpForm.username = __value, CompleteSignUpForm.username));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(67, "\r\n                                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(68, "\r\n                                        ");
                    __builder3.OpenElement(69, "div");
                    __builder3.AddAttribute(70, "class", "form-group");
                    __builder3.AddMarkupContent(71, "\r\n                                            ");
                    __builder3.AddMarkupContent(72, "<label class=\"form-label text-light\">Please save your 12 word recovery\r\n                                                phrase to be\r\n                                                able to recover your wallet if you lose your password</label>\r\n");
#nullable restore
#line 44 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Register Component\CompleteRegistration.razor"
                                             foreach (string phrase in RecoveryPhrase)
                                            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(73, "                                                ");
                    __builder3.OpenElement(74, "span");
                    __builder3.AddAttribute(75, "class", "badge area badge-success");
                    __builder3.AddContent(76, 
#nullable restore
#line 46 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Register Component\CompleteRegistration.razor"
                                                                                        phrase

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(77, "\r\n");
#nullable restore
#line 47 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Register Component\CompleteRegistration.razor"
                                            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(78, "                                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(79, "\r\n                                        ");
                    __builder3.AddMarkupContent(80, @"<div class=""row align-items-center mb-5"">
                                            <div class=""col-7 col-sm-6"">
                                                <button type=""submit"" class=""btn btn-light transition-3d-hover button"">Enter
                                                    Wallet</button>
                                            </div>
                                        </div>
                                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(81, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
