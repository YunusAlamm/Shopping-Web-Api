using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.Orders.Commands;
using Shopping_WebApi.Infrastructure.Repositories;



namespace Shopping_WebApi.Features.Orders.CommandHandlers
{
    public class UpdateOrderCommandHandler(IGenericRepository<Order> _orderRepository) : IRequestHandler<UpdateOrderCommand, bool>
    {
        public async Task<bool> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.GetByIdAsync(request.Id);
            if (order == null)
            {
                return false;
            }

            order.TotalAmount = request.TotalAmount;
            order.IsCompleted = request.IsCompleted;
            order.PurchaseTime = request.PurchaseTime;
            order.Products = request.Products;
            order.CustomerId = request.CustomerId;

            await _orderRepository.UpdateAsync(order);
            return true;
        }
    }

}
