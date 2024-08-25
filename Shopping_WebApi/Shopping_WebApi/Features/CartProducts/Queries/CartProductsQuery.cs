using MediatR;
using Shopping_WebApi.Features.CartProducts.Dto;

namespace Shopping_WebApi.Features.CartProducts.Queries
{
    public class CartProductsQuery : IRequest<IEnumerable<CartProductDto>> 
    {

    }
}
