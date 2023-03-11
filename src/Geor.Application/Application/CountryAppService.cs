using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Geor.Application.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geor.Application
{
    public class CountryAppService : GeorAppServiceBase, ICountryAppService
    {
        private readonly IRepository<Country> _countryRepository;

        public CountryAppService(IRepository<Country> countryRepository)
        {
            _countryRepository = countryRepository;
        }


        public async Task<Country> Create(Country input)
        {
            var countries = await _countryRepository.InsertAsync(input);

            return countries;
        }

        public async Task Delete(int id)
        {
            var country = await _countryRepository.GetAsync(id);

            if (country == null)
            {
                throw new ArgumentException($"Country with Id={id} not found");
            }

            await _countryRepository.DeleteAsync(country);
        }


        public async Task<Country> Get(int id)
        {
            var country = await _countryRepository.GetAsync(id);

            return country;
        }


        public async Task<ListResultDto<CountryListDto>> GetAll(string countryCode, int skipCount = 0, int MaxResult = 10)
        {
            var countries = _countryRepository.GetAll();
            if (!countryCode.IsNullOrEmpty())
            {
                countries = countries.Where(t => t.CountryCode.Contains(countryCode));
            }

            var result = await countries.Skip(skipCount).Take(MaxResult).ToListAsync();

            return new ListResultDto<CountryListDto>(ObjectMapper.Map<List<CountryListDto>>(result));
        }

        public async Task<Country> Update(Country input)
        {
            var country = await _countryRepository.GetAsync(input.Id);
            if (country == null)
            {
                throw new ArgumentException($"Country with Id: {input.Id} not found");
            }
            country.Name = input.Name;
            country.CountryCode = input.CountryCode;

            var updateCountry = await _countryRepository.UpdateAsync(country);

            return updateCountry;
        }
    }
}
