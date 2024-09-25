namespace Shopping_WebApi.Infrastructures.EmailServices
{
    public interface IEmailService
    {
        Task SendEmailAsync(string toName, string subject, string body, string toEmail);
    }

    
}
