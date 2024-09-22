using MediatR;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.PaymentGateway.Commands;
using Shopping_WebApi.Infrastructures.ZarinPalGateway;

namespace Shopping_WebApi.Features.PaymentGateway.CommandHandlers
{
    public class RequestToPayCommandHandler(
        IZarinpalService _service
        ) : IRequestHandler<RequestToPayCommand, string>
    {
        public async Task<string> Handle(RequestToPayCommand request, CancellationToken cancellationToken)
        {
            var requestToPay = new RequestToPay
            {

                MerchantId = request.MerchantId,
                Amount = request.Amount,
                Description = request.Description,
                CallbackUrl = request.CallbackUrl,
                Mobile = request.Mobile,
                Email = request.Email
            };

            var Authority = await _service.RequestToPay(requestToPay);
            return Authority;

        }
    }
}
