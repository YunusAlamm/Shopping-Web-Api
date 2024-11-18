using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Shopping_WebApi.Features.PaymentGateway.Commands;

namespace Shopping_WebApi.Features.PaymentGateway
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAll")]
    [Authorize(Roles = "costumer")]
    public class PaymentMangement(ISender _sender) : ControllerBase
    {
        [HttpPost]
        [Route("RequestToPay")]
        public async Task<IActionResult> RequestToPay(RequestToPayCommand command)
        {
            var result = await _sender.Send(command);
            return Redirect($"https://sandbox.zarinpal.com/pg/StartPay/{result}");
        }

        [HttpPost]
        [Route("PaymentVerification")]
        public async Task<int> ValidatePayment(ValidatePaymentCommand command)
        {
            var result = await _sender.Send(command);
            return result;
        }
    }
}
