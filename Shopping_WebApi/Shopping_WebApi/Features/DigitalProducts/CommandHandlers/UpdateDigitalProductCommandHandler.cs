using FluentValidation;
using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.DigitalProducts.Commands;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.DigitalProducts.CommandHandlers
{
    public class UpdateDigitalProductCommandHandler(
        IGenericRepository<DigitalProduct> _productRepository,
        IValidator<UpdateDigitalProductCommand> _validator
        ) : IRequestHandler<UpdateDigitalProductCommand, bool>
    {
        public async Task<bool> Handle(UpdateDigitalProductCommand request, CancellationToken cancellationToken)
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
            product.DigitalFormat = request.DigitalFormat;
            product.DownloadLink = request.DownloadLink;
            product.Genre = request.Genre;

            await _productRepository.UpdateAsync(product);
            return true;
        }
    }


}
