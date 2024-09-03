using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Infrastructure.Repositories;
using Shopping_WebApi.Features.CartProduct.Commands;
using FluentValidation;
using AutoMapper;

namespace Shopping_WebApi.Features.CartProducts.CommandHandlers
{
    public class DeleteCartProductCommandHandler(

        IGenericRepository<Cart_Product> _genericRepository,
        IValidator<DeleteCartProductCommand> _validator
        
        ): IRequestHandler<DeleteCartProductCommand,bool>
    {

       

        public async Task<bool> Handle(DeleteCartProductCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            await _genericRepository.DeleteAsync(request.Id);
            return true;

        }
    }
}
