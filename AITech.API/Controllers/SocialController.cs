using AITech.Business.Services.SocialServices;
using AITech.DTO.SocialDtos;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialController(ISocialService _service) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var socials = await _service.TGetAllAsync();
            return Ok(socials);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var social = await _service.TGetByIdAsync(id);
            return Ok(social);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateSocialDto dto)
        {
            await _service.TCreateAsync(dto);
            return Created();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.TDeleteAsync(id);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateSocialDto dto)
        {
            await _service.TUpdateAsync(dto);
            return NoContent();
        }

    }
}
