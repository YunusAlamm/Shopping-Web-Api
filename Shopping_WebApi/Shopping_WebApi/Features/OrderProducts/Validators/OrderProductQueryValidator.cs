using FluentValidation;
using Shopping_WebApi.Features.OrderProducts.Queries;

namespace Shopping_WebApi.Features.OrderProducts.Validators
{
    public class OrderProductQueryValidator : AbstractValidator<OrderProductQuery>
    {
        public OrderProductQueryValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull();
        }
    }


}




