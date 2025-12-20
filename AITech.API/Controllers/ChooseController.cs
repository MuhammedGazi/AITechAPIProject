using AITech.Business.Services.ChooseServices;
using AITech.DTO.ChooseDtos;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChooseController(IChooseService _service) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var chooses = await _service.TGetAllAsync();
            return Ok(chooses);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var choose = await _service.TGetByIdAsync(id);
            return Ok(choose);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateChooseDto dto)
        {
            await _service.TCreateAsync(dto);
            return Created();
        }

        [HttpPut]
        public async Task<IActionResult> Udpate(UpdateChooseDto dto)
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
