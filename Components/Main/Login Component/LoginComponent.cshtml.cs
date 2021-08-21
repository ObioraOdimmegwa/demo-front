using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Client.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
namespace Client
{
    [Layout(typeof(AuthLayout))]
    public class LoginComponent : ComponentBase
    {

        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IAuthenticationService authService { get; set; }
        [Inject]
        public ModelManager ModelManager { get; set; }

        public LoginForm LoginForm { get; set; } = new LoginForm();
        public TwoFactorForm TwoFactorForm { get; set; } = new TwoFactorForm();
        public string ErrorMessage { get; set; }
        public string returnUrl { get; set; }
        public bool RequireTwoFactor { get; set; } = false;
        public string TwoFactorCode { get; set; }
        public bool inProcess = false;
        public User user;

        protected override async Task OnInitializedAsync()
        {
            Uri uri = new Uri(NavigationManager.Uri);
            returnUrl = HttpUtility.ParseQueryString(uri.Query).Get("returnUrl");
            returnUrl = string.IsNullOrEmpty(returnUrl) ? "/wallet" : returnUrl;
            await base.OnInitializedAsync();
        }

        public async Task OnValidSubmit()
        {
            ErrorMessage = string.Empty;

            if (inProcess) return;
            inProcess = true;
            try
            {
                var res = await authService.Login(new LoginRequest
                {
                    Email = LoginForm.email,
                    Password = LoginForm.password
                });
                // login successful
                if(res.IsSuccessful)
                {
                    // 2 factor auth not required
                    if(string.IsNullOrEmpty(res.TwoFactorCode))
                    {
                        await ModelManager.Download();
                        if(ModelManager.User.HasCompletedRegistration)
                            NavigationManager.NavigateTo("/wallet");
                        else
                            NavigationManager.NavigateTo("/complete-registration");
                    }
                    // 2 factor code required 
                    else
                    {
                        RequireTwoFactor = true;
                    }
                }
                else
                {
                    ErrorMessage = res.ErrorMessage;
                }
            }
            catch {}
            finally { inProcess = false; }
        }

        public async Task ConfirmTwoFactor()
        {
            ErrorMessage = string.Empty;
            if (inProcess) return;
            inProcess = true;
            try
            {
                var res = await authService.Login(new Login2AuthRequest {
                    email = LoginForm.email, token = TwoFactorForm.Code
                });
                if(res.IsSuccessful)
                {
                    await ModelManager.Download();
                    NavigationManager.NavigateTo("/wallet");
                }
                else
                {
                    ErrorMessage = res.ErrorMessage;
                }
            }
            catch {}
            finally { inProcess = false; }
        }
    }
    public class LoginForm
    {
        [Required(ErrorMessage = "Enter your email address")]
        public string email { get; set; }
        [Required(ErrorMessage = "Enter your password")]
        public string password { get; set; }
    }
    public class TwoFactorForm
    {
        [Required(ErrorMessage = "Please provide two factor authentication code"),
        MinLength(5),MaxLength(5)]
        public string Code { get; set; }
    }

}
