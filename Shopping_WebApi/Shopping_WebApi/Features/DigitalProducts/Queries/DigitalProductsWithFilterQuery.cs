using MediatR;
using Shopping_WebApi.Features.DigitalProducts.Dto;


namespace Shopping_WebApi.Features.DigitalProducts.Queries
{
    public class DigitalProductsWithFilterQuery : IRequest<List<DigitalProductDto>> 
    {
        public string Genre { get; set; }
        public List<Core.Entities.Category> Categories { get; set; }
        public string DigitalFormat { get; set; }
    }

}
