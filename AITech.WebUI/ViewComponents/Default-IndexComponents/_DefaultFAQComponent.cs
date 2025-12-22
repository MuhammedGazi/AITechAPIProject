using AITech.WebUI.Services.FAQServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.Default_IndexComponents
{
    public class _DefaultFAQComponent(IFAQService _service) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var faq = await _service.GetAllAsync();
            return View(faq);
        }
    }
}
