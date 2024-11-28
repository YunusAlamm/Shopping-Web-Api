using AutoMapper;
using FluentValidation;
using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.DigitalProducts.Dto;
using Shopping_WebApi.Features.DigitalProducts.Queries;
using Shopping_WebApi.Infrastructure.Repositories;

public class DigitalProductQueryHandler(
    IGenericRepository<DigitalProduct> _productRepository, 
    IMapper mapper,
    IValidator<DigitalProductQuery> _validator
    ) : IRequestHandler<DigitalProductQuery, DigitalProductDto>
{
    public async Task<DigitalProductDto> Handle(DigitalProductQuery request, CancellationToken cancellationToken)
    {
        var validationResult = _validator.Validate(request);
        if (!validationResult.IsValid) 
        {
            throw new ValidationException(validationResult.Errors);
        }

        var product = await _productRepository.GetByIdAsync(request.Id);
        if (product == null)
        {
            return null;
        }
        

        return mapper.Map<DigitalProductDto>(product);
    }
}
