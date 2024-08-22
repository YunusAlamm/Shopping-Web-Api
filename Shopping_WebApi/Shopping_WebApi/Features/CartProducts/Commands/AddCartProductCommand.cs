using MediatR;

namespace Shopping_WebApi.Features.CartProduct.Commands
{
    public class AddCartProductCommand : IRequest<bool>
    {
        public Guid CartId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
