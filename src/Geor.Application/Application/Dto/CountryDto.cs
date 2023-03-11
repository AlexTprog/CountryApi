using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace Geor.Application.Dto
{
    public class CountryDto : EntityDto
    {
        [Required]
        [StringLength(Country.MaxNameLength)]
        public string Name { get; set; }
        [Required]
        [StringLength(Country.MaxCodeLength)]
        public string CountryCode { get; set; }
    }
}
