using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geor.Application.Dto
{
    [AutoMapTo(typeof(Country))]
    public class CreateCountryInput
    {
        [Required]
        [StringLength(Country.MaxNameLength)]
        public string Name { get; set; }
        [Required]
        [StringLength(Country.MaxCodeLength)]
        public string CountryCode { get; set; }
    }

}
