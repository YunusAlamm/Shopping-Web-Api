using MediatR;
using Shopping_WebApi.Features.CartProducts.Dto;

namespace Shopping_WebApi.Features.CartProducts.Queries
{
    public class CartProductQuery: IRequest<CartProductDto>
    {
        public Guid Id { get; set; }
    }
}
