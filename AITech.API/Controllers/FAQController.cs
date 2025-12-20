using AITech.Business.Services.FAQServices;
using AITech.DTO.FAQDtos;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FAQController(IFAQService _service) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var faqs = await _service.TGetAllAsync();
            return Ok(faqs);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var faq = await _service.TGetByIdAsync(id);
            return Ok(faq);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateFAQDto dto)
        {
            await _service.TCreateAsync(dto);
            return Created();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateFAQDto dto)
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
