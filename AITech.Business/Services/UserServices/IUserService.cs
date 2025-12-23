using AITech.DTO.TokenDtos;
using AITech.DTO.UserDtos;
using Microsoft.AspNetCore.Identity;

namespace AITech.Business.Services.UserServices
{
    public interface IUserService
    {
        Task<IdentityResult> CreateUserAsync(CreateUserDto dto);
        Task<TokenResponseDto> LoginAsync(LoginUserDto dto);
    }
}
