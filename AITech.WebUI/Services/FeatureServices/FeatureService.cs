using AITech.WebUI.DTO.FeatureDtos;

namespace AITech.WebUI.Services.FeatureServices
{
    public class FeatureService : IFeatureService
    {
        private readonly HttpClient _client;

        public FeatureService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7053/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateFeatureDto dto)
        {
            await _client.PostAsJsonAsync("feature", dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("feature/" + id);
        }

        public Task<List<ResultFeatureDto>> GetAllAsync()
        {
            return _client.GetFromJsonAsync<List<ResultFeatureDto>>("feature");
        }

        public Task<UpdateFeatureDto> GetByIdAsync(int id)
        {
            return _client.GetFromJsonAsync<UpdateFeatureDto>("feature/" + id);
        }

        public async Task UpdateAsync(UpdateFeatureDto dto)
        {
            await _client.PutAsJsonAsync("feature", dto);
        }
    }
}
