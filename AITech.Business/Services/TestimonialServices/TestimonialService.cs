using AITech.DataAccess.Repositories.TestimonialRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.TestimonialDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.TestimonialServices
{
    public class TestimonialService(ITestimonialRepository _repository, IUnitOfWork _unitOfWork) : ITestimonialService
    {
        public async Task TCreateAsync(CreateTestimonialDto createDto)
        {
            var testimonial = createDto.Adapt<Testimonial>();
            await _repository.CreateAsync(testimonial);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var testimonial = await _repository.GetByIdAsync(id);
            if (testimonial is null)
            {
                throw new Exception("Testimonial bulunamadı");
            }
            _repository.Delete(testimonial);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultTestimonialDto>> TGetAllAsync()
        {
            var testimonials = await _repository.GetAllAsync();
            return testimonials.Adapt<List<ResultTestimonialDto>>();
        }

        public async Task<ResultTestimonialDto> TGetByIdAsync(int id)
        {
            var testimonial = await _repository.GetByIdAsync(id);
            if (testimonial is null)
            {
                throw new Exception("testimonial bulunamadı");
            }
            return testimonial.Adapt<ResultTestimonialDto>();
        }

        public async Task TUpdateAsync(UpdateTestimonialDto updateDto)
        {
            var testimonial = updateDto.Adapt<Testimonial>();
            _repository.Update(testimonial);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
