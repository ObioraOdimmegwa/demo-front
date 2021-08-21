using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Newtonsoft.Json;

namespace Client
{
    public class AuthResponse
    {
        public bool IsSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string TwoFactorCode { get; set; }
    }

    public class AuthenticationService : IAuthenticationService
    {
        private readonly HttpClient _client;
        private readonly AuthenticationStateProvider _authStateProvider;
        private readonly ILocalStorageService _localStorage;

        public AuthenticationService(HttpClient client, AuthenticationStateProvider authStateProvider, ILocalStorageService localStorage)
        {
            _client = client;
            _authStateProvider = authStateProvider;
            _localStorage = localStorage;
        }

        public async Task<AuthResponse> Login(LoginRequest userForAuthentication)
        {
            var content = JsonConvert.SerializeObject(userForAuthentication);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            HttpResponseMessage authResult = await _client.PostAsync("login", bodyContent);
            if (authResult.IsSuccessStatusCode)
            {
                var loginResponse = JsonConvert.DeserializeObject<LoginResponse>(await authResult.Content.ReadAsStringAsync());
                // 2 factor enabled
                if (!string.IsNullOrEmpty(loginResponse.TwoFactorCode))
                {
                    return new AuthResponse
                    {
                        TwoFactorCode = loginResponse.TwoFactorCode,
                        IsSuccessful = true,
                        ErrorMessage = string.Empty
                    };
                }
                // 2 factor disabled
                await _localStorage.SetItemAsync("authToken", loginResponse.Token);
                ((AuthStateProvider)_authStateProvider).NotifyUserAuthentication(loginResponse.Token);
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", loginResponse.Token);
                return new AuthResponse
                {
                    TwoFactorCode = string.Empty,
                    IsSuccessful = true,
                    ErrorMessage = string.Empty,
                };
            }
            else
            {
                var errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(await authResult.Content.ReadAsStringAsync());
                return new AuthResponse
                {
                    IsSuccessful = false,
                    ErrorMessage = errorResponse.ErrorMessage,
                    TwoFactorCode = string.Empty
                };
            }
        }

        public async Task<AuthResponse> Login(Login2AuthRequest auth)
        {
            var content = JsonConvert.SerializeObject(auth);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var res = await _client.PostAsync("login-2auth", bodyContent);
            if (res.IsSuccessStatusCode)
            {
                var loginResponse = JsonConvert.DeserializeObject<LoginResponse>(await res.Content.ReadAsStringAsync());
                await _localStorage.SetItemAsync("authToken", loginResponse.Token);
                ((AuthStateProvider)_authStateProvider).NotifyUserAuthentication(loginResponse.Token);
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", loginResponse.Token);
                return new AuthResponse
                {
                    TwoFactorCode = string.Empty,
                    IsSuccessful = true,
                    ErrorMessage = string.Empty,
                };
            }
            else 
            {
                var errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(await res.Content.ReadAsStringAsync());
                return new AuthResponse
                {
                    TwoFactorCode = string.Empty,
                    IsSuccessful = false,
                    ErrorMessage = errorResponse.ErrorMessage
                };
            }
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            ((AuthStateProvider)_authStateProvider).NotifyUserLogout();
            _client.DefaultRequestHeaders.Authorization = null;
        }

        public async Task<AuthResponse> RegisterUser(LoginRequest userForRegistration)
        {
            var content = JsonConvert.SerializeObject(userForRegistration);
            HttpContent bodyContent = new StringContent(content,Encoding.UTF8,"application/json");
            var res = await _client.PostAsync("register",bodyContent);
            if(res.IsSuccessStatusCode)
            {
                return new AuthResponse {
                    IsSuccessful = true
                };
            }
            else
            {
                var errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(await res.Content.ReadAsStringAsync());
                return new AuthResponse {
                    IsSuccessful = false,
                    ErrorMessage = errorResponse.ErrorMessage
                };
            }
        }

    }
}