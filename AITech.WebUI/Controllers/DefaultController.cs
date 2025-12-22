using AITech.WebUI.Services.GeminiServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Controllers
{
    public class DefaultController(IGeminiService _geminiService) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AIGet(string prompt)
        {
            if (!string.IsNullOrEmpty(prompt))
            {
                var response = await _geminiService.GetGeminiDataAsync(prompt);
                return Json(response);
            }
            return Json("Lütfen geçerli bir soru giriniz.");
        }
    }
}
