using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace Client
{
    public class ReceiveForm
    {
        [Required]
        public string Currency { get; set; }
        [Required(ErrorMessage = "Enter receive amount"),
        MinValueValidation(minValue: 0, errorMessage: "Amount must be greater than 0")]
        public double Amount { get; set; }
    }

    public class ReceiveCryptoPageComponent : ComponentBase
    {
        [Inject]
        public ModelManager ModelManger { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public HttpClient _client { get; set; }

        [Parameter]
        public string crypto { get; set; }

        public ReceiveForm ReceiveForm { get; set; } = new ReceiveForm();
        public bool inProcess;


        protected override async Task OnInitializedAsync()
        {
            if (inProcess) return;
            inProcess = true;
            try
            {
                ReceiveForm.Currency = Currencies.List[0];
                if (string.IsNullOrEmpty(crypto) || !Coins.List.Any(c => c == crypto))
                {
                    NavigationManager.NavigateTo("/receive-crypto-assets");
                    return;
                }
            }
            catch
            {
                NavigationManager.NavigateTo("/receive-crypto-assets");
            }
            finally
            {
                inProcess = false;
            }
            await base.OnInitializedAsync();
        }

        public async Task GenerateAddress()
        {
            if (inProcess) return;
            inProcess = true;
            try
            {
                var content = JsonConvert.SerializeObject(new TransactionUploadRequest
                {
                    Amount = ReceiveForm.Amount,
                    Type = TransactionType.Receive,
                    Currency = ReceiveForm.Currency,
                    Coin = crypto
                });
                var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
                var res = await _client.PostAsync("transactions", bodyContent);
                if (res.IsSuccessStatusCode)
                {
                    var tranRes = JsonConvert.DeserializeObject<TransactionResponse>(await res.Content.ReadAsStringAsync());
                    NavigationManager.NavigateTo($"/transaction/{tranRes.Id}");
                }
            }
            catch { }
            finally { inProcess = false; }
        }

        public string GetCoinIcon()
        {
            string coin = Coins.List.FirstOrDefault(c => c == crypto);
            if (string.IsNullOrEmpty(coin))
                return "";
            return coin.ToLower() + ".png";
        }
    }
}