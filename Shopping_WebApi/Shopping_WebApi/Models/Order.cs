namespace Shopping_WebApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public RegularUser Owner { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Product> Products { get; set; }
        public decimal TotalAmount { get; set; }


        public Order()
        {
            Products = new List<Product>();
        }
    }
}