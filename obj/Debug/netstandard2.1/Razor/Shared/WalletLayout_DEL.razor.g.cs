#pragma checksum "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Shared\WalletLayout_DEL.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bff7350d6aa67c7b00ee5e3959258c1854f44510"
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
#line 1 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Shared\WalletLayout_DEL.razor"
using Components;

#line default
#line hidden
#nullable disable
    public partial class WalletLayout_DEL : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __Blazor.Client.Shared.WalletLayout_DEL.TypeInference.CreateCascadingValue_0(__builder2, 3, 4, 
#nullable restore
#line 7 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Shared\WalletLayout_DEL.razor"
                               this

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(5, "\r\n        <link rel=\"stylesheet\" href=\"stylesheets/dashlite.css?ver=2.2.0\">\r\n        <link id=\"skin-default\" rel=\"stylesheet\" href=\"stylesheets/theme.css?ver=2.2.0\">\r\n        ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "nk-app-root");
                __builder2.AddMarkupContent(8, "\r\n            ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "nk-main ");
                __builder2.AddMarkupContent(11, "\r\n                ");
                __builder2.OpenComponent<Client.Shared.WalletSideNav>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "nk-wrap");
                __builder2.AddMarkupContent(16, "\r\n                    ");
                __builder2.OpenComponent<Client.Shared.WalletNav>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.AddContent(19, 
#nullable restore
#line 15 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Shared\WalletLayout_DEL.razor"
                     Body

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(20, "\r\n                    ");
                __builder2.OpenComponent<Client.Shared.WalletFooter>(21);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n    ");
            }
            ));
            __builder.AddAttribute(26, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(27, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\Expl0it90\Desktop\Finlexis Seperated\Client\Shared\WalletLayout_DEL.razor"
 
    [Inject]
    public AuthenticationStateProvider authStateProvider { get; set; }
    [Inject]
    public ModelManager ModelManager { get; set; }
    [Inject]
    public NavigationManager NavigationManager { get; set; }
    public bool inProcess = false;

    protected override async Task OnInitializedAsync()
    {
        if (inProcess) return;
        inProcess = true;
        try
        {
            ModelManager.Updated += Updated;
            AuthenticationState authState = await authStateProvider.GetAuthenticationStateAsync();
            if (authState == ((AuthStateProvider)authStateProvider)._anonymous)
            {
                ((AuthStateProvider)authStateProvider).NotifyUserLogout();
                return;
            }
            await ModelManager.Download();
        }
        catch
        {
            NavigationManager.NavigateTo("/login");
        }
        finally
        {
            inProcess = false;
        }
        await base.OnInitializedAsync();
    }
    private Task Updated()
    {
        InvokeAsync(StateHasChanged);
        return Task.CompletedTask;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Client.Shared.WalletLayout_DEL
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
