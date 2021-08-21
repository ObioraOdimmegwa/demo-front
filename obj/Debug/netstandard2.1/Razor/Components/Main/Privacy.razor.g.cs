#pragma checksum "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Components\Main\Privacy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4ca8a0123f2e1b9b80fd664c812d4197dcd208f"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Components.Main
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/privacy")]
    public partial class Privacy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"working-process-section\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-8  col-md-6\">\r\n                <div class=\"working-process\">\r\n                    <ul class=\"working-process-list\">\r\n                        <li>\r\n                            <div class=\"working-process-step\">\r\n                                <h4>Privacy Policy</h4>\r\n                                <div class=\"process-details\">\r\n                                    <p>By using our Services, you are agreeing to these terms. Please read them\r\n                                        carefully.</p>\r\n                                    <p>Our Services are very diverse, so sometimes additional terms or product\r\n                                        requirements (including age requirements) may apply. Additional terms will be\r\n                                        available with the relevant Services, and those additional terms\r\n                                        become part of your agreement with us if you use those Services.</p>\r\n                                    <div class=\"mb-7\">\r\n                                        <div class=\"mb-3\">\r\n                                            <br>\r\n                                            <h4>Using our services</h4>\r\n                                        </div>\r\n                                        <p>You must follow any policies made available to you within the Services.</p>\r\n                                        <p>Don’t misuse our Services. For example, don’t interfere with our Services or\r\n                                            try to access them using a method other than the interface and the\r\n                                            instructions that we provide. You may use our Services only\r\n                                            as permitted by law, including applicable export and re-export control laws\r\n                                            and regulations. We may suspend or stop providing our Services to you if you\r\n                                            do not comply with our terms or policies or if we are investigating\r\n                                            suspected misconduct.</p>\r\n                                        <p>Using our Services does not give you ownership of any intellectual property\r\n                                            rights in our Services or the content you access. You may not use content\r\n                                            from our Services unless you obtain permission from its owner or\r\n                                            are otherwise permitted by law. These terms do not grant you the right to\r\n                                            use any branding or logos used in our Services. Don’t remove, obscure, or\r\n                                            alter any legal notices displayed in or along with our Services.</p>\r\n                                    </div>\r\n                                    <div class=\"mb-7\">\r\n                                        <div class=\"mb-3\">\r\n                                            <br>\r\n                                            <h4>Privacy and copyright protection</h4>\r\n                                        </div>\r\n                                        <p>Privacy is a human right and software should help protect your rights.\r\n                                            We don’t have access to your funds (private keys).\r\n                                            We only require your email address.</p>\r\n                                    </div>\r\n                                    <div class=\"mb-7\">\r\n                                        <div class=\"mb-3\">\r\n                                            <br>\r\n                                            <h4>Device information</h4>\r\n                                        </div>\r\n                                        <p>We may collect information about the mobile device you use to access our\r\n                                            mobile application, including the hardware model, operating system and\r\n                                            version, unique device identifiers and mobile network information. This\r\n                                            information will never be communicated to third-parties unless you provide\r\n                                            prior specific consent</p>\r\n                                    </div>\r\n                                    <div class=\"mb-7\">\r\n                                        <div class=\"mb-3\">\r\n                                            <br>\r\n                                            <h4>Other kinds of information you may provide to us</h4>\r\n                                        </div>\r\n                                        <p>Your email address, virtual currency addresses, mobile phone number and any\r\n                                            other information you choose to provide will never be communicated to\r\n                                            third-parties unless you provide prior specific consent.</p>\r\n                                    </div>\r\n                                    <div class=\"mb-7\">\r\n                                        <div class=\"mb-3\">\r\n                                            <br>\r\n                                            <h4>Blockchain Transactions</h4>\r\n                                        </div>\r\n                                        <p>Your blockchain transactions may be relayed through servers (“nodes”) and\r\n                                            will be publicly visible due to the public nature of distributed ledger\r\n                                            systems.</p>\r\n                                    </div>\r\n                                    <div class=\"mb-7\">\r\n                                        <div class=\"mb-3\">\r\n                                            <br>\r\n                                            <h4>Communication with Third-Party Servers</h4>\r\n                                        </div>\r\n                                        <p>Exchange rates, balances, transactions and other blockchain information may\r\n                                            be read from or relayed to, third-party servers. We cannot guarantee the\r\n                                            privacy of your Internet connection.</p>\r\n                                    </div>\r\n                                    <div class=\"mb-7\">\r\n                                        <div class=\"mb-3\">\r\n                                            <br>\r\n                                            <h4>All User Information is Confidential</h4>\r\n                                        </div>\r\n                                        <p>Your personally identifying information will be kept strictly confidential\r\n                                            and never provided to third parties (other than in an aggregated, anonymized\r\n                                            report such as the number of users per month). All Finlexis staff are bound\r\n                                            by confidentiality agreements.</p>\r\n                                    </div>\r\n                                    <div class=\"mb-7\">\r\n                                        <div class=\"mb-3\">\r\n                                            <br>\r\n                                            <h4>Acceptance</h4>\r\n                                        </div>\r\n                                        <p>By using Finlexis website, you signify your agreement to this Policy. Finlexis\r\n                                            reserves the right to change this Privacy Policy at any time. Any changes\r\n                                            will be posted so that you are always aware of what information we collect,\r\n                                            how we use it and under what circumstances we disclose it.</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591