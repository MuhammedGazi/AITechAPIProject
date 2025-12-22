using AITech.WebUI.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.Default_IndexComponents
{
    public class _DefaultTestimonialComponent(ITestimonialService _service) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var testimonial = await _service.GetAllAsync();
            return View(testimonial);
        }
    }
}
