using AutoMapper;
using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.Orders.Dto;
using Shopping_WebApi.Features.Orders.Queries;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.Orders.QueryHandlers
{


    public class OrderQueryHandler(
        IGenericRepository<Order> _orderRepository,
        IMapper _mapper
        ) : IRequestHandler<OrderQuery, OrderDto>
    {
        public async Task<OrderDto> Handle(OrderQuery request, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.GetByIdAsync(request.Id);
            if (order == null)
            {
                return null;
            }

            return _mapper.Map<OrderDto>(order);
        }
    }

}
