using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Client
{
    public class OverviewComponent : ComponentBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public ModelManager ModelManager { get; set; }
        public string BaseUrl { get; set; }

        protected override async Task OnInitializedAsync()
        {
            BaseUrl = NavigationManager.BaseUri;
            await base.OnInitializedAsync();
        }
    }
}