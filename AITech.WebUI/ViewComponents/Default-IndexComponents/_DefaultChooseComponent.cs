using AITech.WebUI.Services.ChooseServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.Default_IndexComponents
{
    public class _DefaultChooseComponent(IChooseService _service) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var choose = await _service.GetAllAsync();
            return View(choose);
        }
    }
}
