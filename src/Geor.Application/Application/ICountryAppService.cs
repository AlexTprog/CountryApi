using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Geor.Application.Dto;
using System.Threading.Tasks;

namespace Geor.Application
{
    public interface ICountryAppService : IApplicationService
    {
        Task<Country> Get(GetCountryInput input);
        Task<Country> Create(CreateCountryInput input);
        Task Delete(DeleteCountryInput input);
        Task<Country> Update(UpdateCountryInput input);

        Task<ListResultDto<> GetAll(GetAllCountryInput input);
    }
}
