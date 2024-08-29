using AutoMapper;
using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.DigitalProducts.Dto;
using Shopping_WebApi.Features.DigitalProducts.Queries;
using Shopping_WebApi.Infrastructure.Repositories;

public class DigitalProductsQueryHandler(
    IGenericRepository<Product> _productRepository,
    IMapper _mapper) : IRequestHandler<DigitalProductsQuery, List<DigitalProductDto>>
{
    public async Task<List<DigitalProductDto>> Handle(DigitalProductsQuery request, CancellationToken cancellationToken)
    {
        var products = await _productRepository.GetAllAsync();
        return _mapper.Map<List<DigitalProductDto>>(products);
    }
}
