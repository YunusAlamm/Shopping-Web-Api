using AutoMapper;
using FluentValidation;
using MediatR;
using Shopping_WebApi.Features.Categories.Dto;
using Shopping_WebApi.Features.Categories.Queries;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.Categories.QueryHandlers
{
    public class CategoryQueryHandler(
        IGenericRepository<Core.Entities.Category> _genericRepository,
        IValidator<CategoryQuery> _validator,
        IMapper _mapper
        ) : IRequestHandler<CategoryQuery, CategoryDto>
    {
        public async Task<CategoryDto> Handle(CategoryQuery request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            var category = _genericRepository.GetByIdAsync(request.Id);

            return _mapper.Map<CategoryDto>(category);
        }
    }
}
