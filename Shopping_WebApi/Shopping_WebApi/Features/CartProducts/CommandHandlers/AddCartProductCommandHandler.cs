using FluentValidation;
using MediatR;
using OpenQA.Selenium;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.CartProduct.Commands;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.CartProducts.CommandHandlers
{
    public class AddCartProductCommandHandler(
        IGenericRepository<Core.Entities.CartProduct> _genericRepository,
        IGenericRepository<Cart> _cartRepository,
        IValidator<AddCartProductCommand> _validator,
        IGenericRepository<Product> _productRepository
        ) : IRequestHandler<AddCartProductCommand,bool>
    {
        public async Task<bool> Handle(AddCartProductCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            var cart = await _cartRepository.GetByIdAsync(request.CartId);
            var product = await _productRepository.GetByIdAsync(request.ProductId);

            if (cart == null || product == null)
            {
                throw new NotFoundException("Cart or Product not found");
            }

            var cartProduct = new Core.Entities.CartProduct
            {
                
                CartId = request.CartId,
                Cart = cart,
                ProductId = request.ProductId,
                Product = product,
                Quantity = request.Quantity
            };

            await _genericRepository.InsertAsync(cartProduct);
            cart.Products.Add(cartProduct);
            await _cartRepository.UpdateAsync(cart);

            return true;

            
        }

        
    }
}
