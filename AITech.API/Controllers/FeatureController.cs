using AITech.Business.Services.FeatureServices;
using AITech.DTO.FeatureDtos;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController(IFeatureService _service) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var features = await _service.TGetAllAsync();
            return Ok(features);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var feature = await _service.TGetByIdAsync(id);
            return Ok(feature);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateFeatureDto dto)
        {
            await _service.TCreateAsync(dto);
            return Created();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateFeatureDto dto)
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
