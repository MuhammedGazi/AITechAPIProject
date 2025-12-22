using AITech.WebUI.Services.ProjectServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.Default_IndexComponents
{
    public class _DefaultProjectComponent(IProjectService _service) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var project = await _service.GetAllAsync();
            return View(project);
        }
    }
}
