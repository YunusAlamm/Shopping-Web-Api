using MediatR;
using Shopping_WebApi.Features.Carts.Dtos;

namespace Shopping_WebApi.Features.Carts.Queries
{
    public class CartQuery : IRequest<CartDto>
    {
        public Guid Id { get; set; }
    }
}
