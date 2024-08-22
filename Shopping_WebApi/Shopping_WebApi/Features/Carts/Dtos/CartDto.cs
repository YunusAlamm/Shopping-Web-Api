using Shopping_WebApi.Core.Entities;

namespace Shopping_WebApi.Features.Carts.Dtos
{
    public class CartDto
    {
        public Guid Id { get; set; }
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }

        public ICollection<Cart_Product> Products { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
