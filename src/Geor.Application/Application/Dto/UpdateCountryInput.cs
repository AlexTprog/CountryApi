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
    public class UpdateCountryInput
    {
        [Required]
        public int Id { get; set; }
        
        [StringLength(Country.MaxNameLength)]
        public string Name { get; set; }
        
        [StringLength(Country.MaxCodeLength)]
        public string CodeCountry { get; set; }
    }
}
