using Geor.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geor.Application
{
    public interface ICountryAppService
    {
        Task<Country> CreateCountry(Country input);
        Task<Country> DeleteCountry(string countrycode);
        Task<List<Country>> GetCountry(string countrycode);
        Task<List<Country>> GetAllCountry(GetAllCountryInput input);
        Task<Country> UpdateCountry(Country country);
    }
}
