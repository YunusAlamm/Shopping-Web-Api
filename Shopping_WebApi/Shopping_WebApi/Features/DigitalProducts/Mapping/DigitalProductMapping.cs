using AutoMapper;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.DigitalProducts.Dto;
using Shopping_WebApi.Features.DigitalProducts.Mapping.Resolvers;

namespace Shopping_WebApi.Features.DigitalProducts.Mapping
{


    public class DigitalProductMapping : Profile
    {
        public DigitalProductMapping()
        {
            CreateMap<DigitalProduct, DigitalProductDto>()
                .ForMember(dest => dest.CategoryNames,
                           opt => opt.MapFrom<CategoryNamesResolver>());

            CreateMap<DigitalProductDto, DigitalProduct>();
            



        }
    }

}
