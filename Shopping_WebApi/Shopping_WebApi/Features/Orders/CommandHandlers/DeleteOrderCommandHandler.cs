using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.Orders.Commands;
using Shopping_WebApi.Infrastructure.Repositories;



namespace Shopping_WebApi.Features.Orders.CommandHandlers
{
    public class DeleteOrderCommandHandler(IGenericRepository<Order> _orderRepository) : IRequestHandler<DeleteOrderCommand, bool>
    {
        public async Task<bool> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            

            await _orderRepository.DeleteAsync(request.Id);
            return true;
        }
    }

}
