using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultHeaderComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
