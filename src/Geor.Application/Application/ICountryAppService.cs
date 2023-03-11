using Abp.Application.Services.Dto;
using Geor.Application.Dto;
using System.Threading.Tasks;

namespace Geor.Application
{
    public interface ICountryAppService
    {
        Task<Country> Create(Country input);
        Task Delete(int id);
        Task<Country> Get(int id);        
        Task<ListResultDto<CountryListDto>> GetAll(string countryCode, int skipCount,int MaxResult);
        Task<Country> Update(Country input);
    }
}
