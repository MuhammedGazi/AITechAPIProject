using AITech.WebUI.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.Default_IndexComponents
{
    public class _DefaultAboutComponent(IAboutService _service) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var about = await _service.GetAllAsync();
            return View(about);
        }
    }
}
