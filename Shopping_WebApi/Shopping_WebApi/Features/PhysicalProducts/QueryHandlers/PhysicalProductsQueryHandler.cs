using AutoMapper;
using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.PhysicalProducts.Dto;
using Shopping_WebApi.Features.PhysicalProducts.Queries;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.PhysicalProducts.QueryHandlers
{
    public class PhysicalProductsQueryHandler(
        IGenericRepository<PhysicalProduct> _genericRepository,
        IMapper _mapper) : IRequestHandler<PhysicalProductsQuery, List<PhysicalProductDto>>
    {
        public async Task<List<PhysicalProductDto>> Handle(PhysicalProductsQuery request, CancellationToken cancellationToken)
        {
            var physicalProducts = await _genericRepository.GetAllAsync();

            return _mapper.Map<List<PhysicalProductDto>>(physicalProducts);
        }
    }
}
