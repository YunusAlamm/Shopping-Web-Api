using AutoMapper;
using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.Orders.Dto;
using Shopping_WebApi.Features.Orders.Queries;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.Orders.QueryHandlers
{
    public class OrdersQueryHandler(
        IGenericRepository<Order> _orderRepository,
        IMapper _mapper
        ) : IRequestHandler<OrdersQuery, List<OrderDto>>
    {
        public async Task<List<OrderDto>> Handle(OrdersQuery request, CancellationToken cancellationToken)
        {
            var orders = await _orderRepository.GetAllAsync();
            return _mapper.Map<List<OrderDto>>(orders);
        }
    }

}
