using Shopping_WebApi.Core.Models;


namespace Shopping_WebApi.Infrastructures.Services.ZarinPalGateway
{
    public interface IZarinpalService
    {
        Task<string> RequestToPay(RequestToPay request);
        Task<int> Validate(RequestToValidatePayment request);

    }
}
