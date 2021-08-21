using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Collections.Generic;
using Client.Shared;

namespace Client
{
    public class SignUpForm
    {
        [Required(ErrorMessage = "Please enter your email address"),
        EmailAddress(ErrorMessage = "Please enter a valid email address (e.g youremail@example.com")]    
        public string email { get; set; }
        [Required(ErrorMessage = "Password requires a minimum of 8 characters"),
        
        MinLength(length: 8, ErrorMessage = "Password requires a minimum of 8 characters")]
        public string password { get; set; }
        [Compare(nameof(SignUpForm.password), ErrorMessage = "Passwords do not match")]
        public string confirmpassword { get; set; }
        [ValueValidation(expectValue: true, errorMessage: "Please accept our Terms and Conditions to proceed")]
        public bool accept { get; set; }
        public string refcode { get; set; }
    }

    [Layout(typeof(AuthLayout))]
    public class RegisterComponent : ComponentBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IAuthenticationService authService { get; set; }
        [Inject]
        public ModelManager ModelManager { get; set; }

        public SignUpForm SignUpForm { get; set; } = new SignUpForm();
        public string ErrorMessage;
        public bool inProcess = false;

        protected override Task OnInitializedAsync()
        {

            Uri uri = new Uri(NavigationManager.Uri);
            SignUpForm.refcode = HttpUtility.ParseQueryString(uri.Query).Get("refcode");
            return base.OnInitializedAsync();
        }

        public async Task OnValidSubmit()
        {
            ErrorMessage = string.Empty;
            if (inProcess) return;
            inProcess = true;
            try
            {
                var res = await authService.RegisterUser(new LoginRequest {
                    Email = SignUpForm.email,Password = SignUpForm.password
                });
                if(res.IsSuccessful)
                {
                    // login ueer
                    var loginRes = await authService.Login(new LoginRequest {
                        Email = SignUpForm.email, Password = SignUpForm.password
                    });
                    if(loginRes.IsSuccessful)
                    {
                        await ModelManager.Download();
                        NavigationManager.NavigateTo("/complete-registration");
                    }
                    else 
                    {
                        ErrorMessage = "An error has occured, please try again";
                    }
                }
                else
                {
                    ErrorMessage = res.ErrorMessage;
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