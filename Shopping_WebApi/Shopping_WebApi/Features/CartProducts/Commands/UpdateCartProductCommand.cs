using MediatR;

namespace Shopping_WebApi.Features.CartProduct.Commands
{
    public class UpdateCartProductCommand: IRequest<bool>
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }

    }
}
