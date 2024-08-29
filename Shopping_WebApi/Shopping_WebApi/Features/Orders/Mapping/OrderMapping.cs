using AutoMapper;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.Orders.Dto;

namespace Shopping_WebApi.Features.Orders.Mapping
{
    public class OrderMapping: Profile
    {
        public OrderMapping()
        
        {
            CreateMap<Order, OrderDto>();
            CreateMap<OrderDto, Order>();
        }
    }
}
