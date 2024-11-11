using Shopping_WebApi.Core.Entities;

namespace Shopping_WebApi.Features.Carts.Dtos
{
    public class CartDto
    {
        public Guid Id { get; set; }
        

        public ICollection<Core.Entities.CartProduct> Products { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
