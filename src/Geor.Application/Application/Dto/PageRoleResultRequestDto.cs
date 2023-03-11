using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geor.Application.Dto
{
    public class PageCountryResultRequestDto: PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
