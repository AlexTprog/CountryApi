using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geor.Application.Dto
{
    public class CreateCountry
    {
        [Required]
        public string Name { get; set; }

        public string CountryCode { get; set; }
    }
}
