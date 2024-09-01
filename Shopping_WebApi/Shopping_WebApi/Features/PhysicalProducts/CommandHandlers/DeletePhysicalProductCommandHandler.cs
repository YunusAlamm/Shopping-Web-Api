using FluentValidation;
using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.PhysicalProducts.Commands;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.PhysicalProducts.CommandHandlers
{
    public partial class AddPhysicalProductCommandHandler
    {
        public class DeletePhysicalProductCommandHandler(
       IGenericRepository<PhysicalProduct> _productRepository,
       IValidator<DeletePhysicalProductCommand> _validator
       ) : IRequestHandler<DeletePhysicalProductCommand, bool>
        {
            public async Task<bool> Handle(DeletePhysicalProductCommand request, CancellationToken cancellationToken)
            {
                var validatioResult = _validator.Validate(request);
                if (!validatioResult.IsValid)
                {


                    throw new ValidationException(validatioResult.Errors);

                }


                await _productRepository.DeleteAsync(request.Id);
                return true;
            }
        }



    }





}
