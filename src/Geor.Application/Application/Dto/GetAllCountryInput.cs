using Abp.AutoMapper;

namespace Geor.Application.Dto
{
    [AutoMapTo(typeof(Country))]
    public class GetAllCountryInput
    {
        public int SkipCount { get; set; }
        public int MaxResultCount { get; set; }
    }
}
