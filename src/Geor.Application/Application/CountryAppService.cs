using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.UI;
using Geor.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geor.Application
{
    public class CountryAppService : IApplicationService, ICountryAppService
    {
        private readonly IRepository<Country> _countryRepository;

        public CountryAppService(IRepository<Country> countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public Task<Country> Create(CreateCountryInput input)
        {
            throw new NotImplementedException();
        }

        public Task<Country> Delete(DeleteCountryInput input)
        {
            throw new NotImplementedException();
        }

        public Task<Country> Get(GetCountryInput input)
        {
            throw new NotImplementedException();
        }

        public Task<Country> GetAll(GetAllCountryInput input)
        {
            throw new NotImplementedException();
        }

        public Task<Country> Update(UpdateCountryInput input)
        {
            throw new NotImplementedException();
        }
    }
}
