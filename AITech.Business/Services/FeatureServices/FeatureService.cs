using AITech.DataAccess.Repositories.FeatureRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.FeatureDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.FeatureServices
{
    public class FeatureService(IFeatureRepository _repository, IUnitOfWork _unitOfWork) : IFeatureService
    {
        public async Task TCreateAsync(CreateFeatureDto createDto)
        {
            var feature = createDto.Adapt<Feature>();
            await _repository.CreateAsync(feature);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var feature = await _repository.GetByIdAsync(id);
            if (feature is null)
            {
                throw new Exception("Feature bulunamadı");
            }
            _repository.Delete(feature);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultFeatureDto>> TGetAllAsync()
        {
            var features = await _repository.GetAllAsync();
            return features.Adapt<List<ResultFeatureDto>>();
        }

        public async Task<ResultFeatureDto> TGetByIdAsync(int id)
        {
            var feature = await _repository.GetByIdAsync(id);
            if (feature is null)
            {
                throw new Exception("feature bulunamadı");
            }
            return feature.Adapt<ResultFeatureDto>();
        }

        public async Task TUpdateAsync(UpdateFeatureDto updateDto)
        {
            var feature = updateDto.Adapt<Feature>();
            _repository.Update(feature);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
