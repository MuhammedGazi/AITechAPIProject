using AITech.WebUI.DTO.FAQDtos;

namespace AITech.WebUI.Services.FAQServices
{
    public class FAQService : IFAQService
    {
        private readonly HttpClient _client;

        public FAQService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7053/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateFAQDto dto)
        {
            await _client.PostAsJsonAsync("faq", dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("faq/" + id);
        }

        public Task<List<ResultFAQDto>> GetAllAsync()
        {
            return _client.GetFromJsonAsync<List<ResultFAQDto>>("faq");
        }

        public Task<UpdateFAQDto> GetByIdAsync(int id)
        {
            return _client.GetFromJsonAsync<UpdateFAQDto>("faq/" + id);
        }

        public async Task UpdateAsync(UpdateFAQDto dto)
        {
            await _client.PutAsJsonAsync("faq", dto);
        }
    }
}
