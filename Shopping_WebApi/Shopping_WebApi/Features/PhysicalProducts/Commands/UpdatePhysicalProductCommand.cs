using MediatR;

namespace Shopping_WebApi.Features.PhysicalProducts.Commands
{
    public class UpdatePhysicalProductCommand: IRequest<bool>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public List<Core.Entities.Category> Categories { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool? IsSoldOut { get; set; }


        public Dictionary<string, string> Attributes { get; set; }

        public double Weight { get; set; }
        public string Dimensions { get; set; }
        public bool IsReturnable { get; set; }
        public int Quantity { get; set; }

    }
}
