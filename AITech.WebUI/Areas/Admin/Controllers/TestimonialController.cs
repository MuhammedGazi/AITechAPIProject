using AITech.WebUI.DTO.TestimonialDtos;
using AITech.WebUI.Services.TestimonialServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TestimonialController(ITestimonialService _service) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var testimonial = await _service.GetAllAsync();
            return View(testimonial);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateTestimonialDto dto)
        {
            await _service.CreateAsync(dto);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var testimonial = await _service.GetByIdAsync(id);
            return View(testimonial);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateTestimonialDto dto)
        {
            await _service.UpdateAsync(dto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
