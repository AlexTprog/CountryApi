using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geor.Application.Dto
{
    [AutoMapFrom(typeof(Country))]
    public class CountryListDto : EntityDto
    {
        public string Name { get; set; }
        public string CountryCode { get; set; }
    }
}
