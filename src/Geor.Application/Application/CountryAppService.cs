using Geor.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geor.Application
{
    public class CountryAppService : GeorAppServiceBase, ICountryAppService
    {       
        public Task<Country> CreateCountry(Country input)
        {
            throw new NotImplementedException();
        }

        public Task<Country> DeleteCountry(string countrycode)
        {
            throw new NotImplementedException();
        }

        public Task<List<Country>> GetAllCountry(GetAllCountryInput input)
        {
            throw new NotImplementedException();
        }

        public Task<List<Country>> GetCountry(string countrycode)
        {
            throw new NotImplementedException();
        }

        public Task<Country> UpdateCountry(Country country)
        {
            throw new NotImplementedException();
        }
    }
}
