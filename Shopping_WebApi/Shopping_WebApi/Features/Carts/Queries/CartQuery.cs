using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shopping_WebApi.Features.Carts.Dtos;

namespace Shopping_WebApi.Features.Carts.Queries
{
    public class CartQuery : IRequest<CartDto>
    {
        [FromQuery]
        public Guid Id { get; set; }
    }
}
