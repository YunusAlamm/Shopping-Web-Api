using FluentValidation;
using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.DigitalProducts.Commands;
using Shopping_WebApi.Features.PhysicalProducts.Commands;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.PhysicalProducts.CommandHandlers
{
    public partial class AddPhysicalProductCommandHandler(
        IGenericRepository<PhysicalProduct> _genericRepository,
        IValidator<AddPhysicalProductCommand> _validator
        ) : IRequestHandler<AddPhysicalProductCommand, bool>
    {
        public async Task<bool> Handle(AddPhysicalProductCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            var physicalProduct = new PhysicalProduct
            {
                Name = request.Name,
                Image = request.Image,
                Categories = request.Categories,
                Price = request.Price,
                Description = request.Description,
                IsSoldOut = request.IsSoldOut ?? false,
                Attributes = request.Attributes,
                Weight = request.Weight,
                Dimensions = request.Dimensions,
                Quantity = request.Quantity,
                IsReturnable = request.IsReturnable
            };
            await _genericRepository.InsertAsync(physicalProduct);
            return true;
        }



    }





}
