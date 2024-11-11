using AutoMapper;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.CartProducts.Dto;

namespace Shopping_WebApi.Features.CartProducts.Mapping
{
    public class CartProductMapping: Profile
    {
        public CartProductMapping() 
        {
            CreateMap<Core.Entities.CartProduct, CartProductDto>();
            CreateMap<CartProductDto, Core.Entities.CartProduct>();

        }
    }
}
