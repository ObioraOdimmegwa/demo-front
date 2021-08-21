using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;
using Newtonsoft.Json;

namespace Client
{
    public class UserModelResponse
    {
        public User user { get; set; }
        public UserWallet wallet { get; set; }
    }
    public class ModelManager
    {
        private User _user = new User();
        private UserWallet _wallet = new UserWallet();
        public User User => _user;
        public UserWallet Wallet => _wallet;
        public event Func<Task> Updated;

        public HttpClient _client;
        public AuthenticationStateProvider AuthenticationStateProvider;

        public ModelManager(HttpClient client,
            AuthenticationStateProvider authenticationStateProvider)
        {
            _client = client;
            AuthenticationStateProvider = authenticationStateProvider;
        }

        public void Notify()
        {
            Updated?.Invoke();
        }

        public async Task Download()
        {
            var res = await _client.GetAsync("/user");
            if (res.IsSuccessStatusCode)
            {
                var model = JsonConvert.DeserializeObject<UserModelResponse>(await res.Content.ReadAsStringAsync());
                if (model.user == null || model.user == new User())
                {
                    ((AuthStateProvider)AuthenticationStateProvider).NotifyUserLogout();
                }
                else
                {
                    _user = model.user;
                    _wallet = model.wallet;
                    Notify();
                }
            }
            else if (res.StatusCode == System.Net.HttpStatusCode.Forbidden ||
                res.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                ((AuthStateProvider)AuthenticationStateProvider).NotifyUserLogout();
            }
            var ratesRes = await _client.GetAsync("exchange-rates");
            if (ratesRes.IsSuccessStatusCode)
            {
                var rates = JsonConvert.DeserializeObject<RatesResponse>(await ratesRes.Content.ReadAsStringAsync());
                ExchangeRates.UpdateRates(rates);
            }
        }
        public async Task Upload()
        {
            var content = JsonConvert.SerializeObject(new UserModelResponse
            {
                user = _user,
                wallet = _wallet
            });
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var res = await _client.PostAsync("/user", bodyContent);
            if (res.IsSuccessStatusCode)
            {
                Notify();
            }
            if (res.StatusCode == System.Net.HttpStatusCode.Forbidden ||
                res.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                ((AuthStateProvider)AuthenticationStateProvider).NotifyUserLogout();
            }
        }
    }
}