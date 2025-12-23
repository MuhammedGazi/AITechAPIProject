using AITech.Business.Services.JwtServices;
using AITech.DTO.TokenDtos;
using AITech.DTO.UserDtos;
using AITech.Entity.Entities;
using Mapster;
using Microsoft.AspNetCore.Identity;

namespace AITech.Business.Services.UserServices
{
    public class UserService(UserManager<AppUser> _userManager, IJwtService jwtService) : IUserService
    {
        public async Task<IdentityResult> CreateUserAsync(CreateUserDto dto)
        {
            var user = dto.Adapt<AppUser>();
            var result = await _userManager.CreateAsync(user, dto.Password);
            return result;
        }

        public async Task<TokenResponseDto> LoginAsync(LoginUserDto dto)
        {

            var user = await _userManager.FindByEmailAsync(dto.Email);
            if (user is null)
            {
                return new TokenResponseDto { Token = "kullanıcı bulunamadı token yok" };
            }

            var result = await _userManager.CheckPasswordAsync(user, dto.Password);
            if (!result)
            {
                return new TokenResponseDto { Token = "şifre yada kullanıcı adı hatalı token yok" };
            }
            var tokenResponse = await jwtService.GenerateTokenAsync(user);

            return tokenResponse;

        }
    }
}
