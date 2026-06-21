using OutpatientClinicsComplex.Services;
using System.Net;
using System.Net.Mail;

public class EmailService : IEmailService
{
    private readonly ILogger<EmailService> _logger;
    private readonly IConfiguration _configuration;

    public EmailService(ILogger<EmailService> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public async Task SendEmailAsync(string to, string subject, string body)
    {
        try
        {
            // ✅ هات الإعدادات من appsettings.json مع التحقق من null
            var fromEmail = _configuration["EmailSettings:FromEmail"]!;
            var fromPassword = _configuration["EmailSettings:FromPassword"]!;
            var smtpHost = _configuration["EmailSettings:SmtpHost"]!;
            var smtpPort = _configuration.GetValue<int>("EmailSettings:SmtpPort", 587);

            // ✅ التحقق من أن الإعدادات موجودة
            if (string.IsNullOrEmpty(fromEmail) || string.IsNullOrEmpty(fromPassword) || string.IsNullOrEmpty(smtpHost))
            {
                _logger.LogError("❌ Email settings are missing in appsettings.json");
                throw new InvalidOperationException("Email settings are not configured properly.");
            }

            using var client = new SmtpClient(smtpHost, smtpPort)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(fromEmail, fromPassword)
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(fromEmail, "نظام مجمع العيادات"),
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };

            // ✅ الإيميلات المستلمة
            var recipients = new[] { "jokeralbert871@gmail.com", "its.ahmedhelmy@gmail.com" };
            foreach (var recipient in recipients)
            {
                mailMessage.To.Add(recipient);
            }

            await client.SendMailAsync(mailMessage);
            _logger.LogInformation($"✅ Email sent successfully to {string.Join(", ", recipients)}");
        }
        catch (Exception ex)
        {
            _logger.LogError($"❌ Failed to send email: {ex.Message}");
            throw;
        }
    }
}