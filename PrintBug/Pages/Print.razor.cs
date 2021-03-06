using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace PrintBug.Pages
{
    public partial class Print: ComponentBase
    {
        [Inject] private IJSRuntime JS { get; set; } = null!;
        [Inject] private NavigationManager NavigationManager { get; set; } = null!;

        public async Task DoPrint()
        {
            await JS.InvokeVoidAsync("print");
        }

        public void DoGoHome()
        {
            NavigationManager.NavigateTo("/");
        }
    }
}