using MediatR;
using Shopping_WebApi.Core.Entities;

namespace Shopping_WebApi.Features.Orders.Commands
{
    public class AddOrderCommand : IRequest<bool>
    {
        public decimal TotalAmount { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime PurchaseTime { get; set; } = DateTime.UtcNow;
        public ICollection<OrderProduct> Products { get; set; }
        public string CustomerId { get; set; }
    }


}
