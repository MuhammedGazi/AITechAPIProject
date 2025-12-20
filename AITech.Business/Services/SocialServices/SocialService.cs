using AITech.DataAccess.Repositories.SocialRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.SocialDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.SocialServices
{
    public class SocialService(ISocialRepository _repository, IUnitOfWork _unitOfWork) : ISocialService
    {
        public async Task TCreateAsync(CreateSocialDto createDto)
        {
            var social = createDto.Adapt<Social>();
            await _repository.CreateAsync(social);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var social = await _repository.GetByIdAsync(id);
            if (social is null)
            {
                throw new Exception("social bulunamadı");
            }
            _repository.Delete(social);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultSocialDto>> TGetAllAsync()
        {
            var socials = await _repository.GetAllAsync();
            return socials.Adapt<List<ResultSocialDto>>();
        }

        public async Task<ResultSocialDto> TGetByIdAsync(int id)
        {
            var social = await _repository.GetByIdAsync(id);
            if (social is null)
            {
                throw new Exception("social bulunamadı");
            }
            return social.Adapt<ResultSocialDto>();
        }

        public async Task TUpdateAsync(UpdateSocialDto updateDto)
        {
            var social = updateDto.Adapt<Social>();
            _repository.Update(social);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
