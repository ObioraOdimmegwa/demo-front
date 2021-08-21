using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Client
{
    public class PreferenceSettingsComponent : ComponentBase
    {
        [Inject]
        public ModelManager ModelManager { get; set; }

        public string SuccessMessage;
        public string ErrorMessage;
        public bool inProcess;
        public string NewCurrency { get; set; }

        protected override Task OnInitializedAsync()
        {
            NewCurrency = ModelManager.Wallet.Currency;
            return base.OnInitializedAsync();
        }

        public async Task ChangeCurrency()
        {
            if (inProcess) return;
            inProcess = true;

            try
            {
                string currency = Currencies.List.FirstOrDefault(c => c == NewCurrency);
                if (string.IsNullOrEmpty(currency))
                {
                    ErrorMessage = "Failed to change currency";
                }
                else
                {
                    ModelManager.Wallet.Currency = currency;
                    await ModelManager.Upload();
                    SuccessMessage = $"Local currency changed to {currency}";
                }
            }
            catch
            {
                ErrorMessage = "Failed to change default currency";
            }
            finally
            {
                inProcess = false;
            }
        }
    }
}