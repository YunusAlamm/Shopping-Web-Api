namespace Shopping_WebApi.Models
{
    public class Order //when completing the purchase of cart, the detail of cart become an order and saves in orderHistory of user.
    {
        public Guid Id { get; set; }
               
        public decimal TotalAmount { get; set; }

        public bool IsCompleted { get; set; }
        public DateTime PurchaseTime { get; set; }

        public ICollection<OrderProduct> Products { get; set; }

        public string CustomerId { get; set; }
        public Customer Customer { get; set; }



    }
}