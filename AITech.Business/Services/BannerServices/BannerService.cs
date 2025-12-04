using AITech.DataAccess.Repositories.BannerRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.BannerDtos;
using AITech.Entity.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.BannerServices
{
    public class BannerService(IBannerRepository _repository,IUnitOfWork _unitOfWork) : IBannerService
    {
        public async Task TCreateAsync(CreateBannerDto createDto)
        {
            var banner = createDto.Adapt<Banner>();
            await _repository.CreateAsync(banner);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var banner=await _repository.GetByIdAsync(id);
            _repository.Delete(banner);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultBannerDto>> TGetAllAsync()
        {
            var banners=await _repository.GetAllAsync();
            return banners.Adapt<List<ResultBannerDto>>();
        }

        public async Task<ResultBannerDto> TGetByIdAsync(int id)
        {
            var banner=await _repository.GetByIdAsync(id);
            return banner.Adapt<ResultBannerDto>();
        }

        public async Task TMakeActiveAsync(int id)
        {
            var banner=await _repository.GetByIdAsync(id);
            await _repository.MakeActiveAsync(banner);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TMakePassiveAsync(int id)
        {
            var banner = await _repository.GetByIdAsync(id);
            await _repository.MakePassiveAsync(banner);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TUpdateAsync(UpdateBannerDto updateDto)
        {
            var banner=updateDto.Adapt<Banner>();
            _repository.Update(banner);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
