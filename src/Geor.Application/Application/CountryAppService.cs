using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.UI;
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

        public async Task<Country> Create(CreateCountryDto input)
        {
            //Mejorar
            var country = await _countryRepository.InsertAsync(new Country(input.Name, input.CountryCode));            
            return country;
        }

        public async Task Delete(DeleteCountryDto input)
        {
            var country = await _countryRepository.GetAsync(input.Id);

            if (country == null)
            {
                throw new UserFriendlyException($"Country with Id={input.Id} not found.");
            }

            await _countryRepository.DeleteAsync(country);

        }

        public async Task<Country> Get(GetCountryDto input)
        {
            var country = await _countryRepository.GetAsync(input.Id);
            return country;
        }

        public async Task<ListResultDto<CountryListDto>> GetAll(GetAllCountryDto input)
        {
            var countries = _countryRepository.GetAll();
            if (!input.CountryCode.IsNullOrEmpty())
            {
                countries = countries.Where(t => t.CountryCode.Contains(input.CountryCode));
            }

            var result = await countries.Skip(input.SkipCount).Take(input.MaxResultCount).ToListAsync();

            return new ListResultDto<CountryListDto>(ObjectMapper.Map<List<CountryListDto>>(result));
        }

        public async Task<Country> Update(UpdateCountryInput input)
        {
            var country = await _countryRepository.GetAsync(input.Id);
            if (country == null)
            {
                throw new UserFriendlyException($"Country with Id={input.Id} not found.");
            }
            var edit = await _countryRepository.UpdateAsync(country);
            return edit;
        }
    }
}
