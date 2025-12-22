using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.Default_IndexComponents
{
    public class _DefaultAIComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
