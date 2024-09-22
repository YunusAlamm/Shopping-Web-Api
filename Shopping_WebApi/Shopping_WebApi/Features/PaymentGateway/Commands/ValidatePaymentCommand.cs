using MediatR;

namespace Shopping_WebApi.Features.PaymentGateway.Commands
{
    public class ValidatePaymentCommand : IRequest<int>
    {

        public string Authority { get; set; }
        public int Amount { get; set; }
    }
}
