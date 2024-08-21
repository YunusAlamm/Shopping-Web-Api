using MediatR;
using Shopping_WebApi.Features.Carts.Dtos;

namespace Shopping_WebApi.Core.Entities
{
    public class Cart
    {
        public Guid Id { get; set; }
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }

        public ICollection<CartProduct> Products { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
