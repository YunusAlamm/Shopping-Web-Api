namespace Shopping_WebApi.Models
{
    public class Cart
    {
        
        public int Id { get; set; }
        public Costumer Owner { get; set; }
        public Dictionary<Product,int> Products { get; set; }
        public Cart() { Products = new Dictionary<Product, int>(); }
     


    }
}
