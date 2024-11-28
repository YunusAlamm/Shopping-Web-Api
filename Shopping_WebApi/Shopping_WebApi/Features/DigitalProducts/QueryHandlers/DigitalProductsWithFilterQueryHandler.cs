using AutoMapper;
using MediatR;
using NinjaNye.SearchExtensions;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.DigitalProducts.Dto;
using Shopping_WebApi.Features.DigitalProducts.Queries;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.DigitalProducts.QueryHandlers
{
    public class DigitalProductsWithFilterQueryHandler(
        IGenericRepository<DigitalProduct> _genericRepository,
        IMapper _mapper
        ) : IRequestHandler<DigitalProductsWithFilterQuery, List<DigitalProductDto>>
    {
        public async Task<List<DigitalProductDto>> Handle(DigitalProductsWithFilterQuery request, CancellationToken cancellationToken)
        {
            var Products = await _genericRepository.GetAllAsync();
           var digitalProducts = Products.Search(
               p => p.Genre
               ).Containing(request.Genre);

            digitalProducts = (EnumerableStringSearch<DigitalProduct>)Products
                .Where(
                p => p.CategoryIds
                .Any(
                    c => request.CategoryIds
                    .Contains(c))
                );

            digitalProducts = Products
                .Search(
                p => p.DigitalFormat)
                .Containing(
                request.DigitalFormat);


            return _mapper.Map<List<DigitalProductDto>>(digitalProducts);
        }
    }
}