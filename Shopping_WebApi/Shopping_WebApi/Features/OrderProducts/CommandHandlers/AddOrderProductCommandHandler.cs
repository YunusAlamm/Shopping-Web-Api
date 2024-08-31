using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.OrderProducts.Commands;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.OrderProducts.CommandHandlers
{
    public class AddOrderProductCommandHandler(
        IGenericRepository<OrderProduct>    _genericRepository,
        IGenericRepository<Order>   _orderRepository,
        IGenericRepository<Product> _productRepository
        ) : IRequestHandler<AddOrderProductCommand, bool>
    {
        public async Task<bool> Handle(AddOrderProductCommand request, CancellationToken cancellationToken)
        {
           var product = _productRepository.GetByIdAsync( request.ProductId );
            var order = _orderRepository.GetByIdAsync( request.OrderId );
            if (product == null || order == null)
            {
                throw new ArgumentNullException("order or product not found");
            }

            var orderProduct = new OrderProduct
            {
                OrderId = request.OrderId,
                Order = request.Order,
                ProductId = request.ProductId,
                Product = request.Product,
                QuantityOfProduct = request.QuantityOfProduct
            };

           await _genericRepository.InsertAsync( orderProduct );
            return true;
        }
    }
}
