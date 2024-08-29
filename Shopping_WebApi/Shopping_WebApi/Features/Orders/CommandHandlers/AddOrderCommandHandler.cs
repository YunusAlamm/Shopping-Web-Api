using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.Orders.Commands;
using Shopping_WebApi.Infrastructure.Repositories;



namespace Shopping_WebApi.Features.Orders.CommandHandlers
{


    public class AddOrderCommandHandler(IGenericRepository<Order> _orderRepository) : IRequestHandler<AddOrderCommand, bool>
    {
        public async Task<bool> Handle(AddOrderCommand request, CancellationToken cancellationToken)
        {
            var order = new Order
            {
                TotalAmount = request.TotalAmount,
                IsCompleted = request.IsCompleted,
                PurchaseTime = request.PurchaseTime,
                Products = request.Products,
                CustomerId = request.CustomerId
            };

            await _orderRepository.InsertAsync(order);
            return true;
        }
    }

}
