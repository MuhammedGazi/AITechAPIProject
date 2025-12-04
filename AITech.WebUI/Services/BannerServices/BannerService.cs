using AITech.WebUI.DTOs.BannerDtos;

namespace AITech.WebUI.Services.BannerServices
{
    public class BannerService : IBannerService
    {
        private readonly HttpClient _client;

        public BannerService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7053/api/");
            this._client = client;
        }

        public async Task CreateAsync(CreateBannerDto bannerDto)
        {
            await _client.PostAsJsonAsync("banners", bannerDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("banners/" + id);
        }

        public async Task<List<ResultBannerDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultBannerDto>>("banners");
        }

        public async Task<UpdateBannerDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateBannerDto>("banner/" + id);
        }

        public async Task MakeActiveAsync(int id)
        {
            await _client.PatchAsync("banners/makeActive/" + id, null);
        }

        public async Task MakePassiveAsync(int id)
        {
            await _client.PatchAsync("banners/makePassive/" + id, null);
        }

        public async Task UpdateAsync(UpdateBannerDto bannerDto)
        {
            await _client.PutAsJsonAsync("banner", bannerDto);
        }
    }
}
