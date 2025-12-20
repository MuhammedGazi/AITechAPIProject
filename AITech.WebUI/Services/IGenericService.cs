namespace AITech.WebUI.Services
{
    public interface IGenericService<TUpdateDto, TCreateDto, TResultDto>
    {
        Task<List<TResultDto>> GetAllAsync();
        Task<TUpdateDto> GetByIdAsync(int id);
        Task CreateAsync(TCreateDto dto);
        Task UpdateAsync(TUpdateDto dto);
        Task DeleteAsync(int id);
    }
}
