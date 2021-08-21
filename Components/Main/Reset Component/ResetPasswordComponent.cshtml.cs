using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Client.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Newtonsoft.Json;

namespace Client
{
    [Layout(typeof(AuthLayout))]
    public class ResetPasswordComponent : ComponentBase
    {
        [Parameter]
        public string token { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }
        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [Inject]
        public HttpClient _client { get; set; }

        public ResetPasswordForm ResetPasswordForm { get; set; } = new ResetPasswordForm();
        public bool inProcess = false;
        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
        }

        public async Task OnValidSubmit()
        {
            ErrorMessage = string.Empty;
            if (inProcess) return;
            inProcess = true;

            try
            {
                var content = JsonConvert.SerializeObject(new{
                    token = this.token,
                    newpassword = ResetPasswordForm.newpassword
                });
                var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
                var res = await _client.PostAsync("/reset-finish", bodyContent);
                if (res.IsSuccessStatusCode)
                {
                    NavigationManager.NavigateTo("login");
                }
                else
                {
                    ErrorMessage = "An error ocurred, please try again";
                }
            }
            catch 
            {
                    ErrorMessage = "An error ocurred, please try again";
             }
            finally { inProcess = false; }
        }
    }

    public class ResetPasswordForm
    {
        [Required(ErrorMessage = "Password requires a minimum of 8 characters"),
        MinLength(length: 8, ErrorMessage = "Password requires a minimum of 8 alphanumeric characters")]
        public string newpassword { get; set; }
        [Compare(nameof(ResetPasswordForm.newpassword), ErrorMessage = "Passwords do not match")]
        public string confirmpassword { get; set; }
    }
}