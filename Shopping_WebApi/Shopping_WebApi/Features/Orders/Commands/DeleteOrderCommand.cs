using MediatR;

namespace Shopping_WebApi.Features.Orders.Commands
{
    public class DeleteOrderCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
    }


}
