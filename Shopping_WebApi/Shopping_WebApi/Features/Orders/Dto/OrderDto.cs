using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.OrderProducts.Dto;

namespace Shopping_WebApi.Features.Orders.Dto
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime PurchaseTime { get; set; }
        public ICollection<OrderProductDto> Products { get; set; }
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }
    }

}
