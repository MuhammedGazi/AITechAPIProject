using AITech.Business.Services.AboutServices;
using AITech.DTO.AboutDtos;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController(IAboutService _service) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _service.TGetAllAsync();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _service.TGetByIdAsync(id);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAboutDto dto)
        {
            await _service.TCreateAsync(dto);
            return Created();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateAboutDto dto)
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
