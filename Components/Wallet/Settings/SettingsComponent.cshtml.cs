using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;

namespace Client
{
    public class SettingsComponent : ComponentBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public ModelManager ModelManager { get; set; }
        
        public string Header { get; set; }
        public string _component { get; set; }

        protected override Task OnInitializedAsync()
        {
            NavigationManager.LocationChanged += OnLocationChanged;
            SetComponent();
            return base.OnInitializedAsync();
        }
        public void OnLocationChanged(object sender, LocationChangedEventArgs e)
        {
            SetComponent();
        }
        private void SetComponent()
        {
            string uri = NavigationManager.Uri;
            if(uri.Contains("profile"))
            {
                _component = "profile";
                Header = "Personal";
            }
            else if(uri.Contains("password"))
            {
                _component = "security";
                Header = "Security";
            }
            else if(uri.Contains("preference"))
            {
                _component = "preference";
                Header = "Preference";
            }
            else
            {
                _component = "profile";
                Header = "Personal";
            }
            InvokeAsync(StateHasChanged);
        }
    }
}