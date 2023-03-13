using Abp.Application.Services;
using Geor.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geor.Application
{
    public interface ICountryAppService : IApplicationService
    {
        Task<Country> Get(GetCountryInput input);
        Task<Country> Create(CreateCountryInput input);
        Task<Country> Delete(DeleteCountryInput input);
        Task<Country> Update(UpdateCountryInput input);
        Task<Country> GetAll(GetAllCountryInput input);
    }
}
