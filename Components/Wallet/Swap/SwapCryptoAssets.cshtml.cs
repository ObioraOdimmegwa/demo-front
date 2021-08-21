using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Client
{
    public class SwapCryptoAssetsComponent : ComponentBase
    {
        [Inject]
        public ModelManager ModelManager { get; set; }
        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }
    }
}