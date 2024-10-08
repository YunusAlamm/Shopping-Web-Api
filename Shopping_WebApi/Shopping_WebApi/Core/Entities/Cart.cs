﻿using MediatR;
using Shopping_WebApi.Features.Carts.Dtos;

namespace Shopping_WebApi.Core.Entities
{
    public class Cart
    {
        public Guid Id { get; set; }
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }

        public ICollection<Cart_Product> Products { get; set; }
        
        public decimal TotalAmount
        {
            get
            {
                return Products?.Sum(cp => cp.Quantity * cp.Product.Price) ?? 0;
            }
        }
    }
}
