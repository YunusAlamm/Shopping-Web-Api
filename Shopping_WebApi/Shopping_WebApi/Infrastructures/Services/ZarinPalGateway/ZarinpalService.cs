﻿
using Dto.Payment;
using Shopping_WebApi.Core.Models;
using ZarinPal.Class;


namespace Shopping_WebApi.Infrastructures.Services.ZarinPalGateway
{
    public class ZarinpalService(
        Payment _payment
        ) : IZarinpalService
    {
        public async Task<string> RequestToPay(RequestToPay request)
        {

            var result = await _payment.Request(new DtoRequest()
            {
                MerchantId = request.MerchantId,
                Amount = request.Amount,
                Description = request.Description,
                CallbackUrl = request.CallbackUrl,
                Email = request.Email,
                Mobile = request.Mobile


            }, Payment.Mode.sandbox);


            return result.Authority;
        }

        public async Task<int> Validate(RequestToValidatePayment request)
        {
            var verificationResult = await _payment.Verification(new DtoVerification()
            {
                MerchantId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
                Amount = request.Amount,
                Authority = request.Authority
            }, Payment.Mode.sandbox);


            return verificationResult.RefId;
        }
    }
}
