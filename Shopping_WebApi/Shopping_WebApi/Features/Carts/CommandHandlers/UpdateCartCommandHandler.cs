using FluentValidation;
using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.Carts.Commands;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.Carts.CommandHandlers
{
    public class UpdateCartCommandHandler(

        IGenericRepository<Cart> _genericRepository,
        IValidator<UpdateCartCommand> _validator

        )
        : IRequestHandler<UpdateCartCommand, bool>
    {
        public async Task<bool> Handle(UpdateCartCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);

            }

            var updatedCart = new Cart {
                Id = request.Id,
                Products = request.Products

                
            };
            await _genericRepository.UpdateAsync(updatedCart);
            return true;
        }
    }
}
