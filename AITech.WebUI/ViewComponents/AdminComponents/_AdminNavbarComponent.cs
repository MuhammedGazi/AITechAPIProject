using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.AdminComponents
{
    public class _AdminNavbarComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
