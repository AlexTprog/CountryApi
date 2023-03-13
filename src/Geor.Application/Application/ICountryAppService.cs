using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Geor.Application.Dto;
using System.Threading.Tasks;

namespace Geor.Application
{
    public interface ICountryAppService : IApplicationService
    {
        Task<Country> Get(GetCountryDto input);
        Task<Country> Create(CreateCountryDto input);
        Task Delete(DeleteCountryDto input);
        Task<Country> Update(UpdateCountryInput input);
        Task<ListResultDto<CountryListDto>> GetAll(GetAllCountryDto input);
    }
}
