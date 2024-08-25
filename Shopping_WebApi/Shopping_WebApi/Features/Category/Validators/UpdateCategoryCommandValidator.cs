using FluentValidation;
using Shopping_WebApi.Features.Category.Commands;

namespace Shopping_WebApi.Features.Category.Validators
{
    public class UpdateCategoryCommandValidator: AbstractValidator<UpdateCategoryCommand>
    {
        public UpdateCategoryCommandValidator() 
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Choose a name for your Category!");


            RuleFor(x => x.Products)
                .NotEmpty()
                .NotNull()
                .WithMessage("Add or Remove at least one item!");
                
        
            
        
        }
    }
}
