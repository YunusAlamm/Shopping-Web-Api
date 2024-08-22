using MediatR;

namespace Shopping_WebApi.Features.CartProduct.Commands
{
    public class DeleteCartProductCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
