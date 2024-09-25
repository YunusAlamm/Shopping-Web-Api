using MimeKit;
using Shopping_WebApi.Core.Models;

namespace Shopping_WebApi.Infrastructures.EmailServices
{


    public class EmailService(
        EmailConfiguration _emailConfig
        ) : IEmailService
    {
        public async Task SendEmailAsync(string toName, string subject, string body, string toEmail)
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress(_emailConfig.Username, _emailConfig.From));
            email.To.Add(new MailboxAddress(toName, toEmail));
            email.Subject = subject;
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = body };

            using var smtp = new MailKit.Net.Smtp.SmtpClient();
                  smtp.ServerCertificateValidationCallback = (s, c, h, e) => true;
            await smtp.ConnectAsync(_emailConfig.SmtpServer, _emailConfig.Port, MailKit.Security.SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(_emailConfig.Username, _emailConfig.Password);
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }
    }

}
