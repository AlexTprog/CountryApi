using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Geor.Application
{
    [Table("Country")]
    public class Country : Entity
    {
        public const int MaxNameLength = 256;
        public const int MaxCodeLength = 3;

        [Required]
        [StringLength(MaxNameLength)]
        public string Name { get; set; }
        [Required]

        [StringLength(MaxCodeLength)]
        public string CountryCode { get; set; }

        public Country(string name, string countryCode)
        {
            Name = name;
            CountryCode = countryCode;
        }

    }
}
