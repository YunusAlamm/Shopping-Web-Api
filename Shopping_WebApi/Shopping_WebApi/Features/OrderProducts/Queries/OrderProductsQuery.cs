using MediatR;
using Shopping_WebApi.Features.OrderProducts.Dto;

namespace Shopping_WebApi.Features.OrderProducts.Queries
{
    public class OrderProductsQuery : IRequest<IEnumerable<OrderProductDto>>
    {
        
    }
}
