using AITech.Business.Services.CategoryServices;
using AITech.DTO.CategoryDtos;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController(ICategoryService _categoryService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryService.TGetAllAsync();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoryService.TGetByIdAsync(id);
            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryDto dto)
        {
            await _categoryService.TCreateAsync(dto);
            return Ok("kategori oluşturuldu");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _categoryService.TDeleteAsync(id);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> EditCategory(UpdateCategoryDto dto)
        {
            await _categoryService.TUpdateAsync(dto);
            return Ok();
        }

    }
}
