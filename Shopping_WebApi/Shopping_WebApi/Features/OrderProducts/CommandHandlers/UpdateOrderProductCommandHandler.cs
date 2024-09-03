using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.OrderProducts.Commands;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.OrderProducts.CommandHandlers
{
    public class UpdateOrderProductCommandHandler(
        IGenericRepository<OrderProduct> _genericRepository
        ) : IRequestHandler<UpdateOrderProductCommand, bool>
    {
        public  async Task<bool> Handle(UpdateOrderProductCommand request, CancellationToken cancellationToken)
        {
           var orderProduct = await _genericRepository.GetByIdAsync(request.Id);
            

            if (orderProduct == null)
            {
                throw new ArgumentNullException("orderproduct not found");
            }

            orderProduct.QuantityOfProduct = request.QuantityOfProduct;

            await _genericRepository.UpdateAsync( orderProduct );
            return true;


        }
    }
}
