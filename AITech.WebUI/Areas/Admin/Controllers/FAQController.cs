using AITech.WebUI.DTO.FAQDtos;
using AITech.WebUI.Services.FAQServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Operations;
using System.Threading.Tasks;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FAQController(IFAQService _service) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var faq=await _service.GetAllAsync();
            return View(faq);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateFAQDto dto)
        {
            await _service.CreateAsync(dto);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var faq=await _service.GetByIdAsync(id);
            return View(faq);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateFAQDto dto)
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
