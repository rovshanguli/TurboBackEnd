using AutoMapper;
using DomainLayer.Entities;
using ServiceLayer.DTOs.Brand;
using ServiceLayer.DTOs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            //Brand Mappings Start
            CreateMap<Brand, BrandCreateDto>().ReverseMap();
            CreateMap<Brand, BrandGetDto>().ReverseMap();
        }
    }
}
