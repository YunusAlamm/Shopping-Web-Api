using MediatR;

namespace Shopping_WebApi.Features.PaymentGateway.Commands
{
    public class RequestToPayCommand : IRequest<string>
    {
        public string MerchantId { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public string CallbackUrl { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }




    }
}
