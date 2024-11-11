namespace Shopping_WebApi.Core.Entities
{
    public abstract class Product
    {
        
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public byte[]? Image { get; set; }
        public List<Category>? Categories { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public bool? IsSoldOut { get; set; }
        


        public Dictionary<string, string>? Attributes { get; set; }


    }


}
