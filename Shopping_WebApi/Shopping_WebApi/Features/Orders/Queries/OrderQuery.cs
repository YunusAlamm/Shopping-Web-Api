using MediatR;
using Shopping_WebApi.Features.Orders.Dto;
using System;

namespace Shopping_WebApi.Features.Orders.Queries
{


    public class OrderQuery : IRequest<OrderDto>
    {
        public Guid Id { get; set; }

       
    }


}
