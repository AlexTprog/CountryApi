using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geor.Application
{
    public class Country : Entity
    {        
        public virtual string Name { get; set; }
        public virtual string CountryCode { get; set; }

        public Country(string name, string countryCode)
        {
            Name = name;
            CountryCode = countryCode;
        }
           
    }
}
