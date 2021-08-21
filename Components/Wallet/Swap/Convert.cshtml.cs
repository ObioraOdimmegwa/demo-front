using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Client
{
    public class StableCoin
    {
        public string Name { get; set; }
        public string Text { get; set; }
    }

    public static class USDList
    {
        public static List<StableCoin> StableCoins = new List<StableCoin>
        {
            new StableCoin{ Name = "USDT", Text = "USD Tether (USDT)" },
            new StableCoin{ Name = "USDD", Text = "USD Digital (USDD)" }
        };
    }
    public class ConvertComponent : ComponentBase
    {
        [Inject]
        public ModelManager ModelManager { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string crypto { get; set; }

        [MinValueValidation(minValue: 0, errorMessage: "Amount cannot be less than 0")]
        public double SwapAmount { get; set; }
        public bool inProcess = false;

        public string ErrorMessage { get; set; }

        protected override Task OnInitializedAsync()
        {
            if(string.IsNullOrEmpty(crypto) || !Coins.List.Any(c => c == crypto))
            {
                NavigationManager.NavigateTo("/swap-crypto-assets");
            }
            return base.OnInitializedAsync();
        }

        public void Swap()
        {
            if(inProcess)return;
            inProcess = true;
            try
            {
                double from = ModelManager.Wallet.GetCoin(crypto);
                if(SwapAmount > from)
                {
                    ErrorMessage = $"You cannot swap more than {from.ToCoinFormat()} {crypto.ToUpper()}";
                    inProcess = false;
                    return;
                }
            }
            catch
            {

            }
            finally
            {
                inProcess = false;
            }
        }
    }
}