using FluentValidation;
using Shopping_WebApi.Features.Categories.Queries;

namespace Shopping_WebApi.Features.Category.Validators
{
    public class CategoryQueryValidator : AbstractValidator<CategoryQuery>
    {
        public CategoryQueryValidator() 
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .WithMessage("id is empty");
        
            
        
        }
    } 
}
