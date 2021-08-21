using System;
using System.Threading.Tasks;
using Client.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Routing;

namespace Client
{
    [Layout(typeof(WalletLayout))]
    public class WalletParentComponent : ComponentBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public AuthenticationStateProvider authStateProvider { get; set; }
        [Inject]
        public ModelManager ModelManager { get; set; }


        [Parameter]
        public string crypto { get; set; } // crypto passed in for receive page
        [Parameter]
        public string TransactionId { get; set; } // transaction id passed in for transactions page
        public bool inProcess = false;

        public string _component { get; set; }

        protected override async Task OnInitializedAsync()
        {
            _component = GetComponentName();
            ModelManager.Updated += () => {
                InvokeAsync(StateHasChanged);
                return Task.CompletedTask;
            };
            NavigationManager.LocationChanged += OnLocationChanged;
            await base.OnInitializedAsync();
        }
        private void OnLocationChanged(object sender, LocationChangedEventArgs e)
        {
            _component = GetComponentName();
            InvokeAsync(StateHasChanged);
        }
        public string GetComponentName()
        {
            string uri = NavigationManager.Uri;
            if (uri.Contains("/wallet"))
                return "wallet";
            else if (uri.Contains("/settings"))
                return "settings";
            else if (uri.Contains("/receive-crypto-assets"))
                return "receive";
            else if (uri.Contains("/send-crypto-assets"))
                return "send";
            else if (uri.Contains("/swap-crypto-assets"))
                return "swap";
            else if (uri.Contains("/transaction/"))
                return "transaction-receive";
            else if (uri.Contains("transactions"))
                return "transactions";
            else if (uri.Contains("/receive/"))
                return "receive-crypto";
            else if (uri.Contains("/send/"))
                return "send-crypto";
            else if (uri.Contains("/convert/"))
                return "convert";
            else if (uri.Contains("dapp-auto-trade"))
                return "dapp";
            else
                return "wallet";
        }
    }
}