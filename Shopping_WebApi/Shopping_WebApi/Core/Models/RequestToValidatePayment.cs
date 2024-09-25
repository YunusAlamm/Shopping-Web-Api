namespace Shopping_WebApi.Core.Models
{
    public class RequestToValidatePayment
    {
        public int Amount { get; set; }
        public string Authority { get; set; }
    }
}
