using AITech.DataAccess.Repositories.ProjectRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.ProjectDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.ProjectServices
{
    public class ProjectService(IProjectRepository _repository, IUnitOfWork _unitOfWork) : IProjectService
    {
        public async Task TCreateAsync(CreateProjectDto createDto)
        {
            var project = createDto.Adapt<Project>();
            await _repository.CreateAsync(project);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var project = await _repository.GetByIdAsync(id);
            if (project == null)
            {
                throw new Exception("proje bulunamadı");
            }
            _repository.Delete(project);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultProjectDto>> TGetAllAsync()
        {
            var projects = await _repository.GetAllAsync();
            return projects.Adapt<List<ResultProjectDto>>();
        }

        public async Task<ResultProjectDto> TGetByIdAsync(int id)
        {
            var project = await _repository.GetByIdAsync(id);
            return project.Adapt<ResultProjectDto>();
        }

        public async Task<List<ResultProjectDto>> TGetProjectWithCategoriesAsync()
        {
            var project = await _repository.GetProjectWithCategoriesAsync();
            return project.Adapt<List<ResultProjectDto>>();
        }

        public async Task TUpdateAsync(UpdateProjectDto updateDto)
        {
            var project = updateDto.Adapt<Project>();
            _repository.Update(project);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
