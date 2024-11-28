namespace Shopping_WebApi.Features.DigitalProducts.Dto
{
    public class DigitalProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public List<string> CategoryNames { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public Dictionary<string, string> Attributes { get; set; }
        public string DigitalFormat { get; set; }
        public string DownloadLink { get; set; }
        
    }

}
