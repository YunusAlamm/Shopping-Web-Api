using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.Carts.Commands;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.Carts.CommandHandlers
{
    public class AddCartCommandHandler(
        IGenericRepository<Cart> _genericRepository,
        IValidator<AddCartCommand> _validator
        ) : IRequestHandler<AddCartCommand, bool>
    {
        public async Task<bool> Handle(AddCartCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync( request, cancellationToken );
            if ( !validationResult.IsValid )
            {
                throw  new ValidationException(validationResult.Errors);
            }

            var cart  = new Cart 
            {
                CustomerId = request.CustomerId,
                Customer = request.Customer,
                Products = request.Products,
                TotalAmount = request.TotalAmount,
            

            
            
            };

            await _genericRepository.InsertAsync(cart);
            return  true;
            
        }

        
    }
}
