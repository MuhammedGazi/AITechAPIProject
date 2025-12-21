using AITech.WebUI.DTO.AboutItemDtos;

namespace AITech.WebUI.Services.AboutItemServices
{
    public class AboutItemService : IAboutItemService
    {
        private readonly HttpClient _client;

        public AboutItemService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7053/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateAboutItemDto dto)
        {
            await _client.PostAsJsonAsync("AboutItem", dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("AboutItem/" + id);
        }

        public Task<List<ResultAboutItemDto>> GetAllAsync()
        {
            return _client.GetFromJsonAsync<List<ResultAboutItemDto>>("AboutItem");
        }

        public Task<UpdateAboutItemDto> GetByIdAsync(int id)
        {
            return _client.GetFromJsonAsync<UpdateAboutItemDto>("AboutItem/" + id);
        }

        public async Task UpdateAsync(UpdateAboutItemDto dto)
        {
            await _client.PutAsJsonAsync("AboutItem", dto);
        }
    }
}
