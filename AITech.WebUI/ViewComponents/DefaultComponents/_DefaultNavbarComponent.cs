using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultNavbarComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
