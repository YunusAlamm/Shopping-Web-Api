using MediatR;
namespace Shopping_WebApi.Features.DigitalProducts.Commands
{
    public class AddDigitalProductCommand: IRequest<Boolean>
    {
        
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public List<Core.Entities.Category> Categories { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool? IsSoldOut { get; set; }
        public string Genre {  get; set; }


        public Dictionary<string, string> Attributes { get; set; }

        public string DigitalFormat { get; set; }
        public string DownloadLink { get; set; }
    }
}
