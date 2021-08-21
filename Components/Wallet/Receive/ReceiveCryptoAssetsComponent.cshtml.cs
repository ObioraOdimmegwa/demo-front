using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Client
{
    public class ReceiveCryptoAssetsComponent : ComponentBase
    {
        [Inject]
        public ModelManager ModelManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
        }
    }
}