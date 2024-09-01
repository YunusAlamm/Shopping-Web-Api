using AutoMapper;
using FluentValidation;
using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.PhysicalProducts.Dto;
using Shopping_WebApi.Features.PhysicalProducts.Queries;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.PhysicalProducts.QueryHandlers
{
    public class PhysicalProductQueryHandler(
        IGenericRepository<PhysicalProduct> _genericRepository,
        IValidator<PhysicalProductQuery> _validator,
        IMapper _mapper
        ) : IRequestHandler<PhysicalProductQuery, PhysicalProductDto>
    {
        public async Task<PhysicalProductDto> Handle(PhysicalProductQuery request, CancellationToken cancellationToken)
        {
            var validationResult = _validator.Validate(request);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            var product = await _genericRepository.GetByIdAsync(request.Id);
            if (product == null)
            {
                return null;
            }

            return _mapper.Map<PhysicalProductDto>(product);
        }
    }
}
