using FluentValidation;
using Shopping_WebApi.Features.Orders.Queries;


namespace Shopping_WebApi.Features.Orders.Validators
{
    public class OrderQueryValidator : AbstractValidator<OrderQuery> 
    {
        public OrderQueryValidator()
        {
            RuleFor( x => x.Id)
                .NotNull()
                .NotEmpty()
                .WithMessage("Id is required");
        }
    }

}
