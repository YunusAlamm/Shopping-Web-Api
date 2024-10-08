﻿using AutoMapper;
using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.DigitalProducts.Dto;
using Shopping_WebApi.Features.DigitalProducts.Queries;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.DigitalProducts.QueryHandlers
{
    public class DigitalProductsQueryHandler(
        IGenericRepository<DigitalProduct> _genericRepository,
        IMapper _mapper) : IRequestHandler<DigitalProductsQuery, List<DigitalProductDto>>
    {
        public async Task<List<DigitalProductDto>> Handle(DigitalProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _genericRepository.GetAllAsync();
            return _mapper.Map<List<DigitalProductDto>>(products);
        }
    }
}