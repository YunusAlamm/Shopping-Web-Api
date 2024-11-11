using FluentValidation;
using MediatR;
using OpenQA.Selenium;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.CartProduct.Commands;
using Shopping_WebApi.Infrastructure.Repositories;

public class UpdateCartProductCommandHandler(
    IGenericRepository<CartProduct> _cartProductRepository,
    IValidator<UpdateCartProductCommand> _validator
    ) : IRequestHandler<UpdateCartProductCommand, bool>
{
    public async Task<bool> Handle(UpdateCartProductCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await _validator.ValidateAsync(request, cancellationToken);
        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }

        var cartProduct = await _cartProductRepository.GetByIdAsync(request.Id);

        if (cartProduct == null)
        {
            throw new NotFoundException("CartProduct not found");
        }

        cartProduct.Quantity = request.Quantity;

        await _cartProductRepository.UpdateAsync(cartProduct);

        return true;
    }
}
