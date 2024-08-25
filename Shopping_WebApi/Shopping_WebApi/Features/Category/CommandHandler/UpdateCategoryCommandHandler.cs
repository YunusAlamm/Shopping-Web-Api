using FluentValidation;
using MediatR;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.Category.Commands
{
    public class UpdateCategoryCommandHandler(
        IGenericRepository<Core.Entities.Category> _genericRepository,
        IValidator<UpdateCategoryCommand> _validator
        ) : IRequestHandler<UpdateCategoryCommand, bool>
    {
        public async Task<bool> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            var category = new Core.Entities.Category()
            {

                Name = request.Name,
                Products = request.Products

            };
            await _genericRepository.UpdateAsync(category);
            return true;
        }
    }
}
