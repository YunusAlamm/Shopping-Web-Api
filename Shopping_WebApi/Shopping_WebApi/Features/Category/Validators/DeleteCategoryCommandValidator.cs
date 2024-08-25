using FluentValidation;
using Shopping_WebApi.Features.Category.Commands;

namespace Shopping_WebApi.Features.Category.Validators
{
    public class DeleteCategoryCommandValidator: AbstractValidator<DeleteCategoryCommand>
    {
        public DeleteCategoryCommandValidator() 
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .WithMessage("Choose at least one item to remove");
        
            
        
        }
    } 
}
