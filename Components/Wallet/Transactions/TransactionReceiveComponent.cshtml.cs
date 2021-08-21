using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace Client
{
    public class TransactionReceiveComponent : ComponentBase
    {
        [Inject]
        public ModelManager ModelManager { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public HttpClient _client { get; set; }

        [Parameter]
        public string TransactionId { get; set; }

        public bool inProcess = false;
        public Transaction Transaction { get; set; } = new Transaction(); 

        public string Coin { get; set; }
        public string CoinIcon { get; set; }
        public string Address { get; set; }
        public double Amount { get; set; }

        protected override async Task OnInitializedAsync()
        {
            if(inProcess)return;
            inProcess = true;
            try
            {
                var res = await _client.GetAsync($"transactions?id={TransactionId}");
                if(res.IsSuccessStatusCode)
                {
                    var trans = JsonConvert.DeserializeObject<TransactionResponse>(await res.Content.ReadAsStringAsync());
                    if(trans.Type != TransactionType.Receive)
                        throw new InvalidOperationException();

                    Address = CryptoWallets.List.First(c => c.Coin == trans.Coin).Address;
                    Coin = GetCoin(trans.Coin);
                    CoinIcon = GetCoinIcon(trans.Coin);
                    Amount = GetAmount(trans);
                }
                else
                {
                    throw new InvalidOperationException();
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

        public double GetAmount(TransactionResponse tran)
        {
            double coin_usd = tran.Coin.ToUSDRate();
            double curr_usd = tran.Currency.ToUSDRate();
            return ((curr_usd / coin_usd) * tran.Amount).ToCoinFormat();
        }
        private Task OnModelChange()
        {
            InvokeAsync(StateHasChanged);
            return Task.CompletedTask;
        }
        public string GetCoin(string coin)
        {
            string ret = "";
            if(coin == Coins.BTC)ret = "bitcoin";
            else if(coin == Coins.ETH)ret = "ethereum";
            else if(coin == Coins.BCH)ret = "bitcoincash";
            else if(coin == Coins.XRP)ret = "ripple";
            else if(coin == Coins.BNB)ret = "binancecoin";
            else if(coin == Coins.DOGE)ret = "dogecoin";
            else if(coin == Coins.LINK)ret = "chainlink";
            else if(coin == Coins.CHZ)ret = "chiliz";
            else if(coin == Coins.DOT)ret = "polkadot";
            return ret;
        }
        public string GetCoinIcon(string coin)
        {
            if(string.IsNullOrEmpty(coin))
                return "";
            return coin.ToLower() + ".png";
        }
    }
}