using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Client
{
    public class PasswordChageForm
    {
        public string CurrentPassword { get; set; }
        [Required(ErrorMessage = "New Password requires a minimum of 8 characters"),
        MinLength(length: 8, ErrorMessage = "New password requires a minimum of 8 characters")]
        public string NewPassword { get; set; }
    }
    public class SecuritySettingsComponent : ComponentBase
    {
        [Inject]
        public ModelManager ModelManager { get; set; }
        [Inject]
        public HttpClient _client { get; set; }

        public string PasswordChangeSuccess;
        public string PasswordChangeError;
        public string ErrorMessage;
        public string SuccessMessage;
        public bool ShowRecoveryPhrase = false;

        public PasswordChageForm ChangePasswordForm { get; set; } = new PasswordChageForm();
        public bool inProcess = false;

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
        }

        public async Task OnValidPasswordChangeSubmit()
        {
            if (inProcess) return;
            inProcess = true;
            try
            {
                var res = await _client.GetAsync($"check-password?password={ChangePasswordForm.CurrentPassword}");
                if(res.IsSuccessStatusCode)
                {
                    var changeRes = await _client.GetAsync($"change-password?newpassword={ChangePasswordForm.NewPassword}&currentpassword={ChangePasswordForm.CurrentPassword}");
                    if(changeRes.IsSuccessStatusCode)
                    {
                        PasswordChangeSuccess = "Your password has been updated";
                        ChangePasswordForm.NewPassword = string.Empty;
                        ChangePasswordForm.CurrentPassword = string.Empty;
                    }
                    else
                    {
                        PasswordChangeError = "Something went wrong, please try again";
                    }
                }
                else 
                {
                    PasswordChangeError = "Current password is incorrect";
                }
            }
            catch
            {
                PasswordChangeError = "Something went wrong, please try again";
            }
            finally
            {
                inProcess = false;
            }
        }

        public async Task ChangeTwoFactorAuth()
        {
            if (inProcess) return;
            inProcess = true;
            try
            {
                ModelManager.User.TwoFactorEnabled = !ModelManager.User.TwoFactorEnabled;
                await ModelManager.Upload();
                SuccessMessage = "Your authentication mode has been changed";
            }
            catch
            {
                ErrorMessage = "Failed to change two factor authentication mode";
            }
            finally
            {
                inProcess = false;
            }
        }
    }
}