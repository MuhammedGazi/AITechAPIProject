using AITech.DataAccess.Repositories.AboutItemRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.AboutItemDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.AboutItemServices
{
    public class AboutItemService(IAboutItemRepository _repository, IUnitOfWork _unitOfWork) : IAboutItemService
    {
        public async Task TCreateAsync(CreateAboutItemDto createDto)
        {
            var aboutItem = createDto.Adapt<AboutItem>();
            await _repository.CreateAsync(aboutItem);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var aboutItem = await _repository.GetByIdAsync(id);
            if (aboutItem is null)
            {
                throw new Exception("aboutItem bulunamadı");
            }
            _repository.Delete(aboutItem);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultAboutItemDto>> TGetAllAsync()
        {
            var aboutItems = await _repository.GetAllAsync();
            return aboutItems.Adapt<List<ResultAboutItemDto>>();
        }

        public async Task<ResultAboutItemDto> TGetByIdAsync(int id)
        {
            var aboutItem = await _repository.GetByIdAsync(id);
            if (aboutItem is null)
            {
                throw new Exception("AboutItem Bulunumadı");
            }
            return aboutItem.Adapt<ResultAboutItemDto>();
        }

        public async Task TUpdateAsync(UpdateAboutItemDto updateDto)
        {
            var aboutItem = updateDto.Adapt<AboutItem>();
            _repository.Update(aboutItem);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
