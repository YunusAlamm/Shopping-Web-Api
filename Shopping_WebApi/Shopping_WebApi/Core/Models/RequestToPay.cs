namespace Shopping_WebApi.Core.Models
{
    public class RequestToPay
    {
        public Guid Id { get; set; }

        public string MerchantId { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public string CallbackUrl { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
    }
}
