using AITech.Business.Services.UserServices;
using AITech.DTO.TokenDtos;
using AITech.DTO.UserDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserService _userService) : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> CreateUser(CreateUserDto dto)
        {
            var result = await _userService.CreateUserAsync(dto);
            if (result.Succeeded)
            {
                return Ok(new { message = "kullanıcı kaydedildi" });
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult<TokenResponseDto>> Login(LoginUserDto loginDto)
        {
            var response = await _userService.LoginAsync(loginDto);
            return response;
        }
    }
}
