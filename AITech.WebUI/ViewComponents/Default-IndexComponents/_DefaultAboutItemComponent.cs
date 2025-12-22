using AITech.WebUI.Services.AboutItemServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.Default_IndexComponents
{
    public class _DefaultAboutItemComponent(IAboutItemService _service) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var aboutItem = await _service.GetAllAsync();
            return View(aboutItem);
        }
    }
}
