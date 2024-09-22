using Shopping_WebApi.Core.Entities;


namespace Shopping_WebApi.Infrastructures.ZarinPalGateway
{
    public interface IZarinpalService
    {
        Task<string> RequestToPay(RequestToPay request);
        Task<int> Validate(RequestToValidate request);

    }
}
