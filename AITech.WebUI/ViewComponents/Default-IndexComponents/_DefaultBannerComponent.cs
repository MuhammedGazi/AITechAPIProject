using AITech.WebUI.Services.BannerServices;
using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AITech.WebUI.ViewComponents.Default_IndexComponents
{
    public class _DefaultBannerComponent(IBannerService _service) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var banner=await _service.GetAllAsync();
            return View(banner);
        }
    }
}
