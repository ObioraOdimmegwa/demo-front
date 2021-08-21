using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Client
{
    public class ProfileUpateForm
    {
        [Required(ErrorMessage = "Firstname is required")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Lastname is required")]
        public string Lastname { get; set; }
        [Phone(ErrorMessage = "Enter a valid phone number")]
        public string Phonenumber { get; set; }
        public string Address { get; set; }
    }

    public class ProfileSettingsComponent : ComponentBase
    {
        [Inject]
        public ModelManager ModelManager { get; set; }

        public ProfileUpateForm UpdateForm { get; set; } = new ProfileUpateForm();
        public string UpdateSuccess;
        public bool InProcess = false;

        protected override async Task OnInitializedAsync()
        {

            UpdateForm.Firstname = ModelManager.User.Firstname;
            UpdateForm.Lastname = ModelManager.User.LastName;
            UpdateForm.Phonenumber = ModelManager.User.Phone;
            UpdateForm.Address = ModelManager.User.Address;
            await base.OnInitializedAsync();
        }

        public async Task OnValidSubmit()
        {
            if (InProcess) return;
            InProcess = true;
            try
            {
                ModelManager.User.Firstname = UpdateForm.Firstname;
                ModelManager.User.LastName = UpdateForm.Lastname;
                ModelManager.User.Phone = UpdateForm.Phonenumber;
                ModelManager.User.Address = UpdateForm.Address;
                await ModelManager.Upload();
                UpdateSuccess = "Profile update successful";
            }
            catch { }
            finally { InProcess = false; }
        }
    }
}