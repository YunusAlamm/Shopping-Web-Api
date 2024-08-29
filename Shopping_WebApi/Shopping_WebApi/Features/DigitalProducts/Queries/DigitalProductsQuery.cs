using MediatR;
using Shopping_WebApi.Features.DigitalProducts.Dto;


namespace Shopping_WebApi.Features.DigitalProducts.Queries
{
    public class DigitalProductsQuery : IRequest<List<DigitalProductDto>>
    {
    }

}
