using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Client
{
    public class SendForm
    {
        [Required]
        public string Password { get; set; }
        [Required(ErrorMessage = "Enter Amount"),
        MinValueValidation(minValue: 0, errorMessage: "Enter amount above 0")]
        public double Amount { get; set; }
        [Required(ErrorMessage = "Enter recipient address")]
        public string Address { get; set; }
    }

    public class SendCrptoPageComponent : ComponentBase
    {
        [Inject]
        public ModelManager ModelManager { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public HttpClient _client { get; set; }

        [Parameter]
        public string crypto { get; set; }

        public SendForm SendForm { get; set; } = new SendForm();
        public bool inProcess = false;
        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                if (string.IsNullOrEmpty(crypto) || !Coins.List.Any(c => c == crypto))
                {
                    NavigationManager.NavigateTo("/send-crypto-assets");
                    return;
                }
            }
            catch
            {
                NavigationManager.NavigateTo("/send-crypto-assets");
            }
            finally
            {
                inProcess = false;
            }
            await base.OnInitializedAsync();
        }

        public string GetCoinIcon()
        {
            string coin = Coins.List.FirstOrDefault(c => c == crypto);
            if (string.IsNullOrEmpty(coin))
                return "";
            return coin.ToLower() + ".png";
        }
        public async Task Send()
        {
            if (inProcess) return;
            inProcess = true;
            try
            {
                var res = await _client.GetAsync($"check-password?password={SendForm.Password}");
                if (res.IsSuccessStatusCode)
                {
                    double coin = ModelManager.Wallet.GetCoin(crypto);
                    if (SendForm.Amount < coin)
                    {
                        ErrorMessage = $"You cannot send more than {coin.ToCoinFormat()} {crypto}";
                        return;
                    }
                }
                else
                {
                    ErrorMessage = "Your password is incorrect";
                }
            }
            catch { }
            finally { inProcess = false; }
        }
    }
}