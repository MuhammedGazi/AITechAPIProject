using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.AdminComponents
{
    public class _AdminHeaderComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
