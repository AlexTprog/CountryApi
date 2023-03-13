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
    public class CountryAppService : AsyncCrudAppService<Country, CountryDTO>
    {
        private readonly IRepository<Country> _countryRepository;

        public CountryAppService(IRepository<Country> countryRepository) : base(countryRepository)
        {
            _countryRepository = countryRepository;
        }

    }
}
