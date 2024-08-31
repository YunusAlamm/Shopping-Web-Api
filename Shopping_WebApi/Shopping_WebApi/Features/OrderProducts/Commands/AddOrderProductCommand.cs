﻿using MediatR;
using Shopping_WebApi.Core.Entities;

namespace Shopping_WebApi.Features.OrderProducts.Commands
{
    public class AddOrderProductCommand: IRequest<bool>
    {
        public Guid OrderId { get; set; }
        public Order Order { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public int QuantityOfProduct { get; set; }
    }
}
