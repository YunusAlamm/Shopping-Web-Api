using Shopping_WebApi.Core.Entities;

namespace Shopping_WebApi.Features.CartProducts.Dto
{
    public class CartProductDto
    {

        public Guid Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}