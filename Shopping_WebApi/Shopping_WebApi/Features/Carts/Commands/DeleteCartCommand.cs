using MediatR;

namespace Shopping_WebApi.Features.Carts.Commands
{
    public class DeleteCartCommand: IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
