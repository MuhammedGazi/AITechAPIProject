using AITech.Business.Services.GenericServices;
using AITech.DTO.FAQDtos;

namespace AITech.Business.Services.FAQServices
{
    public interface IFAQService : IGenericService<ResultFAQDto, CreateFAQDto, UpdateFAQDto>
    {
    }
}
