using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultScriptComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
