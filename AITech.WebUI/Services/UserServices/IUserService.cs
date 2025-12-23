using AITech.WebUI.DTO.TokenDtos;
using AITech.WebUI.DTO.UserDtos;

namespace AITech.WebUI.Services.UserServices
{
    public interface IUserService
    {
        Task<object> CreateAsync(CreateUserDto userDto);
        Task<TokenResponseDto> LoginAsync(LoginUserDto loginUserDto);
    }
}
