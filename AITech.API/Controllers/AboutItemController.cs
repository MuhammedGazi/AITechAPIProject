using AITech.Business.Services.AboutItemServices;
using AITech.DTO.AboutItemDtos;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutItemController(IAboutItemService _service) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var aboutItems = await _service.TGetAllAsync();
            return Ok(aboutItems);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var aboutItem = await _service.TGetByIdAsync(id);
            return Ok(aboutItem);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAboutItemDto dto)
        {
            await _service.TCreateAsync(dto);
            return Created();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateAboutItemDto dto)
        {
            await _service.TUpdateAsync(dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.TDeleteAsync(id);
            return NoContent();
        }
    }
}
