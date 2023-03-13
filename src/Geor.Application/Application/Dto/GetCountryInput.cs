﻿using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace Geor.Application.Dto
{
    [AutoMapTo(typeof(Country))]
    public class GetCountryInput
    {
        [Required]
        public int Id { get; set; }
    }
}
