using AutoMapper;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.DigitalProducts.Dto;

namespace Shopping_WebApi.Features.DigitalProducts.Mapping
{


    public class DigitalProductMapping : Profile
    {
        public DigitalProductMapping()
        {
            CreateMap<DigitalProductDto, DigitalProduct>();
            CreateMap<DigitalProduct, DigitalProductDto>();



        }
    }

}
