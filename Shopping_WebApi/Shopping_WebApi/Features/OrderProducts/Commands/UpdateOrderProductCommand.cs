using MediatR;

namespace Shopping_WebApi.Features.OrderProducts.Commands
{
    public class UpdateOrderProductCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
        public int QuantityOfProduct { get; set; }

    }
}