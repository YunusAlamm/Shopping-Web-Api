using FluentValidation;
using Shopping_WebApi.Features.Category.Commands;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Features.Category.Validators
{
    public class AddCategoryCommandValidator : AbstractValidator<AddCategoryCommand>
    {
        private readonly IGenericRepository<Core.Entities.Category> _categoryRepository;

        public AddCategoryCommandValidator(IGenericRepository<Core.Entities.Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;

            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Choose a name for your Category!")
                .MustAsync(BeUniqueName).WithMessage("A category with the same name already exists.");
        }

        private async Task<bool> BeUniqueName(string name, CancellationToken cancellationToken)
        {
            return !await _categoryRepository.GetByConditions(c => c.Name == name);
        }
    }
}
