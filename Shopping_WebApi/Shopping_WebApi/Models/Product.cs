namespace Shopping_WebApi.Models
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Cart Cart { get; set; }
        public List<ProductAttribute> Attributes { get; set; }

        public Product()
        {
            Attributes = new List<ProductAttribute>(); //add custom attributes to each product without needing to modify the database schema or the class definition every time.
        }
    }

    public  class ProductAttribute
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
