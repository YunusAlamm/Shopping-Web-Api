using AutoMapper;
using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.OrderProducts.Dto;
using Shopping_WebApi.Features.OrderProducts.Queries;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.OrderProducts.QueryHandlers
{
    public class OrderProductsQueryHandler(
        IGenericRepository<OrderProduct> _genericRepository,
        IMapper _mapper
        ) : IRequestHandler<OrderProductsQuery, IEnumerable<OrderProductDto>>
    {
        public async Task<IEnumerable<OrderProductDto>> Handle(OrderProductsQuery request, CancellationToken cancellationToken)
        {
            var orderProducts = await _genericRepository.GetAllAsync();

          

            return _mapper.Map<IEnumerable<OrderProductDto>>(orderProducts);
        }
    }
}
