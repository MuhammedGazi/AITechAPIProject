using AITech.WebUI.DTO.SocialDtos;

namespace AITech.WebUI.Services.SocialServices
{
    public class SocialService : ISocialService
    {
        private readonly HttpClient _client;

        public SocialService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7053/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateSocialDto dto)
        {
            await _client.PostAsJsonAsync("social", dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("social/" + id);
        }

        public Task<List<ResultSocialDto>> GetAllAsync()
        {
            return _client.GetFromJsonAsync<List<ResultSocialDto>>("social");
        }

        public Task<UpdateSocialDto> GetByIdAsync(int id)
        {
            return _client.GetFromJsonAsync<UpdateSocialDto>("social/" + id);
        }

        public async Task UpdateAsync(UpdateSocialDto dto)
        {
            await _client.PutAsJsonAsync("social", dto);
        }
    }
}
