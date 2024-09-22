namespace Shopping_WebApi.Core.Entities
{
    public class RequestToPay
    {
        public Guid Id { get; set; }
        
        public String MerchantId { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public string CallbackUrl { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
    }

    public class RequestToValidate
    {
        public int Amount { get; set; }
        public string Authority { get; set; }
    }
}
