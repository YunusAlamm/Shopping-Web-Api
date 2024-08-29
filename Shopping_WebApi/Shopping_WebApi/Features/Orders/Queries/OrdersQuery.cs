using MediatR;
using Shopping_WebApi.Features.Orders.Dto;

namespace Shopping_WebApi.Features.Orders.Queries
{
    public class OrdersQuery : IRequest<List<OrderDto>>
    {
    }


}
