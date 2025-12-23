using AITech.WebUI.DTO.TokenDtos;
using AITech.WebUI.DTO.UserDtos;

namespace AITech.WebUI.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly HttpClient _client;

        public UserService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7053/api/");
            _client = client;
        }

        public async Task<object> CreateAsync(CreateUserDto userDto)
        {
            var response = await _client.PostAsJsonAsync("user/register", userDto);
            return response;
        }

        public async Task<TokenResponseDto> LoginAsync(LoginUserDto loginUserDto)
        {
            var response = await _client.PostAsJsonAsync("user/login", loginUserDto);
            return await response.Content.ReadFromJsonAsync<TokenResponseDto>();
        }
    }
}
