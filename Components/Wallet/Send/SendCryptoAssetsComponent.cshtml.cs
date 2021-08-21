using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Client
{
    public class SendCryptoAssetsComponent : ComponentBase
    {
        [Inject]
        public ModelManager ModelManager { get; set; }
    }
}