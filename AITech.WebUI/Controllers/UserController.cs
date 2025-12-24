using AITech.WebUI.DTO.UserDtos;
using AITech.WebUI.Services.UserServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Controllers
{
    public class UserController(IUserService _service) : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(CreateUserDto dto)
        {
            await _service.CreateAsync(dto);
            return RedirectToAction("Login");
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginUserDto dto)
        {
            await _service.LoginAsync(dto);
            return RedirectToAction("Index", "About", new { area = "Admin" });
        }
    }
}
