namespace Shopping_WebApi.Core.Entities
{
    public class Order 
    {
        public Guid Id { get; set; }

        public decimal TotalAmount { get; set; }

        public bool IsCompleted { get; set; }
        public DateTime PurchaseTime { get; set; }= DateTime.Now;

        public ICollection<OrderProduct>? Products { get; set; }

        public string? CustomerId { get; set; }
        public Customer? Customer { get; set; }



    }
}