using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geor.Application.Dto
{
    public class GetAllCountryDto
    {        
        public string CodeCountry { get; set; }

        public string MaxResult { get; set; }
        public string SkipCount { get; set; }

        
    }
}
