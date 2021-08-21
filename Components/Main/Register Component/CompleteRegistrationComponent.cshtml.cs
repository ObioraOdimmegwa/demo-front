using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Client.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace Client
{
    [Layout(typeof(AuthLayout))]
    public class CompleteRegistrationComponent : ComponentBase
    {
        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        ModelManager ModelManager { get; set; }
        [Inject]
        public HttpClient _client { get; set; }

        public CompleteSignUpForm CompleteSignUpForm { get; set; } = new CompleteSignUpForm();
        public string[] RecoveryPhrase { get; set; } = new string[12];
        public bool inProcess = false;
        public string ErrorMessage;

        protected override async Task OnInitializedAsync()
        {
            if (inProcess) return;
            inProcess = true;
            try
            {
                var authState = await ((AuthStateProvider)AuthenticationStateProvider).GetAuthenticationStateAsync();
                if (authState == ((AuthStateProvider)AuthenticationStateProvider)._anonymous)
                {
                    ((AuthStateProvider)AuthenticationStateProvider).NotifyUserLogout();
                    return;
                }
                RecoveryPhrase = ModelManager.User.RecoveryPhrase.Split(" ");
            }
            catch
            {
                NavigationManager.NavigateTo("/");
            }
            finally { inProcess = false; }
            await base.OnInitializedAsync();
        }

        public async Task OnValidSubmit()
        {
            ErrorMessage = string.Empty;
            if (inProcess) return;
            inProcess = true;
            try
            {
                var res = await _client.GetAsync($"validate-username?username={CompleteSignUpForm.username}");
                if (!res.IsSuccessStatusCode)
                {
                    ErrorMessage = $"{CompleteSignUpForm.username} has been used";
                }
                else
                {
                    ModelManager.User.DisplayName = CompleteSignUpForm.username;
                    await ModelManager.Upload();
                    NavigationManager.NavigateTo("/wallet");
                }
            }
            catch { }
            finally { inProcess = false; }
        }
    }

    public class CompleteSignUpForm
    {
        [Required(ErrorMessage = "Enter your username")]
        public string username { get; set; }
    }
}