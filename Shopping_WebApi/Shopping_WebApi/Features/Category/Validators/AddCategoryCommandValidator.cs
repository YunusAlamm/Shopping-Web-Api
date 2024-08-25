using FluentValidation;
using Shopping_WebApi.Features.Category.Commands;

namespace Shopping_WebApi.Features.Category.Validators
{
    public class AddCategoryCommandValidator: AbstractValidator<AddCategoryCommand>
    {
        public AddCategoryCommandValidator() 
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Choose a name for your Category!");
        
            
        
        }
    } 
}
