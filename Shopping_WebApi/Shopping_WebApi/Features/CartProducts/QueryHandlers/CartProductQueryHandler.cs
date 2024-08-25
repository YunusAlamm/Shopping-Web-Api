using AutoMapper;
using FluentValidation;
using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.CartProducts.Dto;
using Shopping_WebApi.Features.CartProducts.Queries;
using Shopping_WebApi.Features.Carts.Dtos;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.CartProducts.QueryHandlers
{
    public class CartProductQueryHandler(
        IGenericRepository<Cart_Product> _genericRepository,
        IValidator<CartProductQuery>  _validator,
        IMapper _mapper
        ) : IRequestHandler<CartProductQuery, CartProductDto>
    {
        public async Task<CartProductDto> Handle(CartProductQuery request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            var cartproduct = _genericRepository.GetByIdAsync(request.Id);

            return _mapper.Map<CartProductDto>( cartproduct );
        }
    }
}
