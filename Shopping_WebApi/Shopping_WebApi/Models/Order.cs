namespace Shopping_WebApi.Models
{
    public class Order //when completing the purchase of cart, the detail of cart become an order and saves in orderHistory of user.
    {
        public int Id { get; set; }
        public Costumer Owner { get; set; }
        public DateTime OrderDate { get; set; }
        public Dictionary<Product, int> Products { get; set; }
        public decimal TotalAmount { get; set; }


        
    }
}