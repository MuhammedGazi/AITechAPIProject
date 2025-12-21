using AITech.WebUI.DTO.TestimonialDtos;

namespace AITech.WebUI.Services.TestimonialServices
{
    public class TestimonialService : ITestimonialService
    {
        private readonly HttpClient _client;

        public TestimonialService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7053/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateTestimonialDto dto)
        {
            await _client.PostAsJsonAsync("testimonial", dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("testimonial/" + id);
        }

        public Task<List<ResultTestimonialDto>> GetAllAsync()
        {
            return _client.GetFromJsonAsync<List<ResultTestimonialDto>>("testimonial");
        }

        public Task<UpdateTestimonialDto> GetByIdAsync(int id)
        {
            return _client.GetFromJsonAsync<UpdateTestimonialDto>("testimonial/" + id);
        }

        public async Task UpdateAsync(UpdateTestimonialDto dto)
        {
            await _client.PutAsJsonAsync("testimonial", dto);
        }
    }
}
