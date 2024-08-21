using AutoMapper;
using FluentValidation;
using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.Carts.Dtos;
using Shopping_WebApi.Features.Carts.Validators;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.Carts.Queries
{
    public class CartQueryHandler(
        IGenericRepository<Cart> _genericRepository,
        IMapper _mapper,
        IValidator<CartQuery> _validator 
        )
        : IRequestHandler<CartQuery, CartDto>
    {


        public async Task<CartDto> Handle(CartQuery request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }
            var cart = await _genericRepository.GetByIdAsync(request.Id);

            return _mapper.Map<CartDto>(request);
        }
    }
}
