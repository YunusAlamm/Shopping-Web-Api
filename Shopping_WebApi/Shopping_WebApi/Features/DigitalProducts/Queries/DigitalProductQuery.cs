using MediatR;
using Shopping_WebApi.Features.DigitalProducts.Dto;


namespace Shopping_WebApi.Features.DigitalProducts.Queries
{


    public class DigitalProductQuery : IRequest<DigitalProductDto>
    {
        public Guid Id { get; set; }

       
    }

}
