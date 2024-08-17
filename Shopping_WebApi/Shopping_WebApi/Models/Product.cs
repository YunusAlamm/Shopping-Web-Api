namespace Shopping_WebApi.Models
{
    public abstract class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        
        public Cart Cart { get; set; }
        public Dictionary<string,string> Attributes { get; set; }

        
    }

    
}
