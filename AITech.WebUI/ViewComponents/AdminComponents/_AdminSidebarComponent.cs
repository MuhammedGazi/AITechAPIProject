using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.AdminComponents
{
    public class _AdminSidebarComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
