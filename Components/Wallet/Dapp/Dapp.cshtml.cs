using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Client
{
    public class  DappComponent : ComponentBase
    {
        [Inject]
        public ModelManager Modelmanager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
        }
    }
}