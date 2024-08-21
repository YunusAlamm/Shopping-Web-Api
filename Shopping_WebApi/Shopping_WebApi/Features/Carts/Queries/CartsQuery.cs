using MediatR;
using Shopping_WebApi.Features.Carts.Dtos;

namespace Shopping_WebApi.Features.Carts.Queries
{
    public class CartsQuery: IRequest<IEnumerable<CartDto>>
    {

    }



}
