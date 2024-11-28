using FluentValidation;
using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.PhysicalProducts.Commands;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.PhysicalProducts.CommandHandlers
{
    public class UpdatePhysicalProductCommandHandler(
    IGenericRepository<PhysicalProduct> _productRepository,
    IValidator<UpdatePhysicalProductCommand> _validator
    ) : IRequestHandler<UpdatePhysicalProductCommand, bool>
    {
        public async Task<bool> Handle(UpdatePhysicalProductCommand request, CancellationToken cancellationToken)
        {
            var validatioResult = _validator.Validate(request);
            if (!validatioResult.IsValid)
            {


                throw new ValidationException(validatioResult.Errors);

            }

            var product = await _productRepository.GetByIdAsync(request.Id);
            if (product == null)
            {
                return false;
            }

            product.Name = request.Name;
            product.Image = request.Image;
            product.CategoryIds = request.CategoryIds;
            product.Price = request.Price;
            product.Description = request.Description;
            product.IsSoldOut = request.IsSoldOut ?? product.IsSoldOut;
            product.Attributes = request.Attributes;
            product.Weight = request.Weight;
            product.Dimensions = request.Dimensions;
            product.Quantity = request.Quantity;
            product.IsReturnable = request.IsReturnable;



            await _productRepository.UpdateAsync(product);
            return true;
        }
    }





}
