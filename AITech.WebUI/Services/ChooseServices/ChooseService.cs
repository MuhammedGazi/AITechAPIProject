using AITech.WebUI.DTO.ChooseDtos;

namespace AITech.WebUI.Services.ChooseServices
{
    public class ChooseService : IChooseService
    {
        private readonly HttpClient _client;

        public ChooseService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7053/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateChooseDto dto)
        {
            await _client.PostAsJsonAsync("choose", dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("choose/" + id);
        }

        public Task<List<ResultChooseDto>> GetAllAsync()
        {
            return _client.GetFromJsonAsync<List<ResultChooseDto>>("choose");
        }

        public Task<UpdateChooseDto> GetByIdAsync(int id)
        {
            return _client.GetFromJsonAsync<UpdateChooseDto>("choose/" + id);
        }

        public async Task UpdateAsync(UpdateChooseDto dto)
        {
            await _client.PutAsJsonAsync("choose", dto);
        }
    }
}
