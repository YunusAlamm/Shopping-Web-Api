using FluentValidation;
using MediatR;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.Category.Commands
{
    public class DeleteCategoryCommandHandler(
        IGenericRepository<Core.Entities.Category> _genericRepository,
        IValidator<DeleteCategoryCommand> _validator
        ) : IRequestHandler<DeleteCategoryCommand, bool>
    {
        public async Task<bool> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
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
