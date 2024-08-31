using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.OrderProducts.Commands;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.OrderProducts.CommandHandlers
{
    public class DeleteOrderProductCommandHandler(
        IGenericRepository<OrderProduct> _genericRepository
        ) : IRequestHandler<DeleteOrderProductCommand, bool>
    {
        public async Task<bool> Handle(DeleteOrderProductCommand request, CancellationToken cancellationToken)
        {
            await _genericRepository.DeleteAsync( request.Id );
            return true;
        }
    }
}
