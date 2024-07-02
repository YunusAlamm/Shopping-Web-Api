namespace Shopping_WebApi.Models
{
    public class Cart
    {
        
        public int Id { get; set; }
        public RegularUser Owner { get; set; }
        public Dictionary<Product,int> Products { get; set; }
        public Cart() { Products = new Dictionary<Product, int>(); }
        public void AddToProducts(Product product, int quantity)
        {
            // Check if the dictionary already contains the product
            if (Products.ContainsKey(product))
            {
                // If it does, update the quantity
                Products[product] += quantity;
            }
            else
            {
                // If it doesn't, add the product with the specified quantity
                Products.Add(product, quantity);
            }
        }


    }
}
