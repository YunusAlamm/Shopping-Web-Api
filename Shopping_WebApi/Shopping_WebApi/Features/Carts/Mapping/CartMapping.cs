using AutoMapper;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.Carts.Dtos;

namespace Shopping_WebApi.Features.Carts.Mapping
{
    public class CartMapping: Profile
    {
        public CartMapping() {
        
            CreateMap<Cart, CartDto>();
            CreateMap<CartDto, Cart>();
        
        }
    }
}
