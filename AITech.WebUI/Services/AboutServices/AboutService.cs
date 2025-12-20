using AITech.WebUI.DTO.AboutDtos;

namespace AITech.WebUI.Services.AboutServices
{
    public class AboutService : IAboutService
    {
        private readonly HttpClient _client;

        public AboutService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7053/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateAboutDto dto)
        {
            await _client.PostAsJsonAsync("about", dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("about/" + id);
        }

        public Task<List<ResultAboutDto>> GetAllAsync()
        {
            return _client.GetFromJsonAsync<List<ResultAboutDto>>("about");
        }

        public Task<UpdateAboutDto> GetByIdAsync(int id)
        {
            return _client.GetFromJsonAsync<UpdateAboutDto>("about/" + id);
        }

        public async Task UpdateAsync(UpdateAboutDto dto)
        {
            await _client.PutAsJsonAsync("about", dto);
        }
    }
}
