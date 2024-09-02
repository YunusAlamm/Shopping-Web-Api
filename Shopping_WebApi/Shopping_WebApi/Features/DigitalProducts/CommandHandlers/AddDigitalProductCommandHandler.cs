using FluentValidation;
using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.DigitalProducts.Commands;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.DigitalProducts.CommandHandlers
{


    public class AddDigitalProductCommandHandler(
        IGenericRepository<DigitalProduct> _productRepository,
        IValidator<AddDigitalProductCommand> _validator
        ) : IRequestHandler<AddDigitalProductCommand, bool>
    {
        public async Task<bool> Handle(AddDigitalProductCommand request, CancellationToken cancellationToken)
        {
            var validatioResult = _validator.Validate(request);
            if (!validatioResult.IsValid)
            {


                throw new ValidationException(validatioResult.Errors);

            }
            var product = new DigitalProduct
            {
                Name = request.Name,
                Image = request.Image,
                Categories = request.Categories,
                Price = request.Price,
                Description = request.Description,
                IsSoldOut = request.IsSoldOut ?? false,
                Attributes = request.Attributes,
                DigitalFormat = request.DigitalFormat,
                DownloadLink = request.DownloadLink
            };

            await _productRepository.InsertAsync(product);
            return true;
        }
    }





}
