using AITech.Business.Services.TestimonialServices;
using AITech.DTO.TestimonialDtos;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController(ITestimonialService _service) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var testimonials = await _service.TGetAllAsync();
            return Ok(testimonials);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var testimonial = await _service.TGetByIdAsync(id);
            return Ok(testimonial);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTestimonialDto dto)
        {
            await _service.TCreateAsync(dto);
            return Created();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateTestimonialDto dto)
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
