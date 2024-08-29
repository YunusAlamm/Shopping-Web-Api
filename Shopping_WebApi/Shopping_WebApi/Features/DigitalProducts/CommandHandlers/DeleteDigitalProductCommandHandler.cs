using FluentValidation;
using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.DigitalProducts.Commands;
using Shopping_WebApi.Infrastructure.Repositories;


namespace Shopping_WebApi.Features.DigitalProducts.CommandHandlers
{
 

    public class DeleteDigitalProductCommandHandler(
        IGenericRepository<Product> _productRepository,
        IValidator<DeleteDigitalProductCommand> _validator
        ) : IRequestHandler<DeleteDigitalProductCommand, bool>
    {
        public async Task<bool> Handle(DeleteDigitalProductCommand request, CancellationToken cancellationToken)
        {
            var validatioResult = _validator.Validate( request );
            if (!validatioResult.IsValid) 
            {


                throw new ValidationException(validatioResult.Errors);
            
            }
          

            await _productRepository.DeleteAsync(request.Id);
            return true;
        }
    }

}
