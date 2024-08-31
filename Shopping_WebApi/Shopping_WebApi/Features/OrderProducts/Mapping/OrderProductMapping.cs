using AutoMapper;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.OrderProducts.Dto;

namespace Shopping_WebApi.Features.OrderProducts.Mapping
{
    public class OrderProductMapping: Profile
    {
        public OrderProductMapping()
        {
            CreateMap<OrderProduct, OrderProductDto>();
            CreateMap<OrderProductDto, OrderProduct>();
        }
    }
}
