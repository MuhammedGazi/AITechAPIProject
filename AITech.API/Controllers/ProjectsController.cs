using AITech.Business.Services.ProjectServices;
using AITech.DTO.ProjectDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController(IProjectService _projectService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var project=await  _projectService.TGetAllAsync();
            return Ok(project);
        }

        [HttpGet("WithCategories")]
        public async Task<IActionResult> GetAllWithCategories()
        {
            var  projects=await  _projectService.TGetProjectWithCategoriesAsync();
            return Ok(projects);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult>  GetById(int id)
        {
            var project=await _projectService.TGetByIdAsync(id);
            if(project is null)
            {
                return BadRequest("proje bulunamadı");
            }
            return Ok(project);
        }

        [HttpPost]
        public async Task<IActionResult>  Create(CreateProjectDto projectDto)
        {
            await _projectService.TCreateAsync(projectDto);
            return Created();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateProjectDto projectDto)
        {
            await  _projectService.TUpdateAsync(projectDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _projectService.TDeleteAsync(id);
            return NoContent();
        }

    }
}
