namespace Shopping_WebApi.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Owner { get; set; }
    }
}
