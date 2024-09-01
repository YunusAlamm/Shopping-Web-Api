using MediatR;

namespace Shopping_WebApi.Features.PhysicalProducts.Commands
{
    public class DeletePhysicalProductCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
