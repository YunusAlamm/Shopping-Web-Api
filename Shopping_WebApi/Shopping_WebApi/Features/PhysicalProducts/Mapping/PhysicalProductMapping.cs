using AutoMapper;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.PhysicalProducts.Dto;

namespace Shopping_WebApi.Features.PhysicalProducts.Mapping
{
    public class PhysicalProductMapping: Profile
    {
        public PhysicalProductMapping() 
        {
            CreateMap<PhysicalProduct, PhysicalProductDto>();
            CreateMap<PhysicalProductDto, PhysicalProduct>();
        }
    }
}
