using Abp.AutoMapper;

namespace Geor.Application.Dto
{
    [AutoMapTo(typeof(Country))]
    public class GetAllCountryDto
    {
        public string CountryCode { get; set; }
        public int SkipCount { get; set; }
        public int MaxResultCount { get; set; } = 10;
    }
}
