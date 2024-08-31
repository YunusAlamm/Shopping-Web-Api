using MediatR;

namespace Shopping_WebApi.Features.OrderProducts.Commands
{
    public class DeleteOrderProductCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
