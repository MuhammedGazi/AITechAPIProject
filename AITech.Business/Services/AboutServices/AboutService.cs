using AITech.DataAccess.Repositories.AboutRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.AboutDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.AboutServices
{
    public class AboutService(IAboutRepository _repository, IUnitOfWork _unitOfWork) : IAboutService
    {
        public async Task TCreateAsync(CreateAboutDto createDto)
        {
            var about = createDto.Adapt<About>();
            await _repository.CreateAsync(about);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var about = await _repository.GetByIdAsync(id);
            if (about is null)
            {
                throw new Exception("project bulunamadı");
            }
            _repository.Delete(about);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultAboutDto>> TGetAllAsync()
        {
            var about = await _repository.GetAllAsync();
            return about.Adapt<List<ResultAboutDto>>();
        }

        public async Task<ResultAboutDto> TGetByIdAsync(int id)
        {
            var about = await _repository.GetByIdAsync(id);
            if (about is null)
            {
                throw new Exception("project bulunamadı");
            }
            return about.Adapt<ResultAboutDto>();
        }

        public async Task TUpdateAsync(UpdateAboutDto updateDto)
        {
            var about = updateDto.Adapt<About>();
            _repository.Update(about);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
