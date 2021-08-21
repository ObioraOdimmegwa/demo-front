using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Threading.Tasks;
using Client.Shared;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace Client
{
    [Layout(typeof(AuthLayout))]
    public class ResetComponent : ComponentBase
    {
        [Inject]
        NavigationManager NavigationManager { get; set; }
        [Inject]
        public HttpClient _client { get; set; }

        public ResetForm ResetForm { get; set; } = new ResetForm();
        public string ErrorMessage { get; set; }
        public string SuccessMessage { get; set; }
        public bool inProcess = false;

        public async Task OnValidSubmit()
        {
            ErrorMessage = string.Empty;
            SuccessMessage = string.Empty;
            if (inProcess) return;
            inProcess = true;

            try
            {
                var res = await _client.GetAsync($"/reset-start?email={ResetForm.email}");
                if(res.IsSuccessStatusCode)
                {
                    SuccessMessage = "We have emailed your password reset link!";
                    ErrorMessage = string.Empty;
                }
                else
                {
                    var error = JsonConvert.DeserializeObject<ErrorResponse>(await res.Content.ReadAsStringAsync());
                    ErrorMessage = error.ErrorMessage;
                }
            }
            catch
            {

            }
            finally
            {
                inProcess = false;
                ResetForm = new ResetForm();
            }
        }
    }

    public class ResetForm
    {
        [Required(ErrorMessage = "Please enter your email"),
        EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string email { get; set; }
    }
}