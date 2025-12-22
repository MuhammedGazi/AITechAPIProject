using AITech.WebUI.Services.CategoryServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.Default_IndexComponents
{
    public class _DefaultServicesComponent(ICategoryService _service):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var service = await _service.GetAllAsync();
            return View(service);
        }
    }
}
