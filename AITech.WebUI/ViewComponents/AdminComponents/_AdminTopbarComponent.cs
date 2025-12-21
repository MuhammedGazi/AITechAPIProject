using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.AdminComponents
{
    public class _AdminTopbarComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
