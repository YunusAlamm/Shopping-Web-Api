using MediatR;
using Shopping_WebApi.Features.OrderProducts.Dto;

namespace Shopping_WebApi.Features.OrderProducts.Queries
{
    public class OrderProductQuery: IRequest<OrderProductDto>
    {
        public Guid Id { get; set; }
    }
}
