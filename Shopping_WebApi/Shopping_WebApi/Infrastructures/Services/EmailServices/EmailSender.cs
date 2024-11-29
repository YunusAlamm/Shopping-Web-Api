using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using MimeKit;
using Shopping_WebApi.Core.Models;

namespace Shopping_WebApi.Infrastructures.Services.EmailServices
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailConfiguration _emailConfig;

        public EmailSender(EmailConfiguration emailConfig)
        {
            if (string.IsNullOrEmpty(emailConfig.SmtpServer))
                throw new ArgumentNullException(nameof(emailConfig.SmtpServer), "SMTP Server cannot be null or empty.");
            if (emailConfig.Port <= 0)
                throw new ArgumentException("Port must be greater than 0.", nameof(emailConfig.Port));
            if (string.IsNullOrEmpty(emailConfig.From))
                throw new ArgumentNullException(nameof(emailConfig.From), "From address cannot be null or empty.");

            _emailConfig = emailConfig;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(_emailConfig.SenderName, _emailConfig.From));
            message.To.Add(new MailboxAddress("", email));
            message.Subject = subject;

            var bodyBuilder = new BodyBuilder { HtmlBody = htmlMessage };
            message.Body = bodyBuilder.ToMessageBody();

            using var client = new SmtpClient();
            try
            {
                await client.ConnectAsync(_emailConfig.SmtpServer, _emailConfig.Port, MailKit.Security.SecureSocketOptions.StartTls);
                await client.AuthenticateAsync(_emailConfig.Username, _emailConfig.Password);
                await client.SendAsync(message);
            }
            catch (Exception ex)
            {
                
                throw new InvalidOperationException("Failed to send email", ex);
            }
            finally
            {
                await client.DisconnectAsync(true);
                client.Dispose();
            }
        }
    }
}
