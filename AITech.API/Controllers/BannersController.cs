using AITech.Business.Services.BannerServices;
using AITech.DTO.BannerDtos;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController(IBannerService _bannerService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var banners = await _bannerService.TGetAllAsync();
            return Ok(banners);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var banner = await _bannerService.TGetByIdAsync(id);
            return Ok(banner);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBannerDto dto)
        {
            await _bannerService.TCreateAsync(dto);
            return Created();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _bannerService.TDeleteAsync(id);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateBannerDto dto)
        {
            await _bannerService.TUpdateAsync(dto);
            return NoContent();
        }

        [HttpPatch("makeActive/{id}")]
        public async Task<IActionResult> MakeActive(int id)
        {
            await _bannerService.TMakeActiveAsync(id);
            return NoContent();
        }

        [HttpPatch("makePassive/{id}")]
        public async Task<IActionResult> MakePassive(int id)
        {
            await _bannerService.TMakePassiveAsync(id);
            return NoContent();
        }

    }
}
