using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace Geor.Application.Dto
{
    [AutoMapFrom(typeof(Country))]
    public class CountryListDto: EntityDto
    {
        public string Name { get; set; }
        public string CountryCode { get; set; }

    }
}
