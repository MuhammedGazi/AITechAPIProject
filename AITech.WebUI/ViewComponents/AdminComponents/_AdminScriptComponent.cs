using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.AdminComponents
{
    public class _AdminScriptComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
