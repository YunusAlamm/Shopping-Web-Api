using FluentValidation;
using MediatR;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.Category.Commands
{
    public class AddCategoryCommandHandler(
        IGenericRepository<Core.Entities.Category> _genericRepository,
        IValidator<AddCategoryCommand> _validator
        ) : IRequestHandler<AddCategoryCommand, bool>
    {
        public async Task<bool> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            var category = new Core.Entities.Category()
            {

                Name = request.Name

            };
            await _genericRepository.InsertAsync(category);
            return true;
        }
    }
}
