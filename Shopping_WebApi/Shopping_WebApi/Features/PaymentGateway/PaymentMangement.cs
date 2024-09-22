using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shopping_WebApi.Features.PaymentGateway.Commands;

namespace Shopping_WebApi.Features.PaymentGateway
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentMangement(ISender _sender) : ControllerBase
    {
        [HttpPost]
        [Route("RequestToPay")]
        public async Task<IActionResult> RequestToPay(RequestToPayCommand command)
        {
            var result = await _sender.Send(command);

            return Redirect($"https://sandbox.zarinpal.com/pg/StartPay/{result}");
        }
    }
}
