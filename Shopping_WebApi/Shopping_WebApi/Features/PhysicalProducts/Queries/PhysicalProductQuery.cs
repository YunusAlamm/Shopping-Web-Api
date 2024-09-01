using MediatR;
using Shopping_WebApi.Features.PhysicalProducts.Dto;

namespace Shopping_WebApi.Features.PhysicalProducts.Queries
{
    public class PhysicalProductQuery: IRequest<PhysicalProductDto>
    {
        public Guid Id { get; set; }
    }
}
