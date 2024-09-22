using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.PaymentGateway.Commands;
using Shopping_WebApi.Infrastructures.ZarinPalGateway;

namespace Shopping_WebApi.Features.PaymentGateway.CommandHandlers
{
    public class ValidatePaymentCommandHandler(
        IZarinpalService _service
        ) : IRequestHandler<ValidatePaymentCommand, int>
    {
        public Task<int> Handle(ValidatePaymentCommand request, CancellationToken cancellationToken)
        {

            var validateRequest = new RequestToValidate
            {
                Authority = request.Authority,
                Amount = request.Amount
            };

            var result = _service.Validate(validateRequest);
            return result;
        }
    }
}
