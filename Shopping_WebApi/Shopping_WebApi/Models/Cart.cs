namespace Shopping_WebApi.Models
{
    public class Cart
    {
        
        public int Id { get; set; }
        public RegularUser Owner { get; set; }
        public List<Product> Products { get; set; }
        public Cart() { Products = new List<Product>(); }
        public void AddToProducts(Product product)
        {
            Products.Add(product);
        }
    }
}
