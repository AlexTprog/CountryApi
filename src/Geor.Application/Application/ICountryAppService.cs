using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Geor.Application.Dto;
using System.Threading.Tasks;

namespace Geor.Application
{
    public interface ICountryAppService : IAsyncCrudAppService<CountryDto, int, PageCountryResultRequestDto, CreateCountryDto, CountryDto>
    {
        Task<Country> Create(CreateCountryDto input);
        Task Delete(int id);
        Task<Country> Get(int id);
        Task<ListResultDto<CountryListDto>> GetAll(GetAllCountryDto getAll);
        Task<Country> Update(Country input);
    }
}
