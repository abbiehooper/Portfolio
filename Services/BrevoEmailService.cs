using brevo_csharp.Api;
using brevo_csharp.Model;
using Configuration = brevo_csharp.Client.Configuration;

namespace AbbiePortfolio.Services;

public class BrevoEmailService : IEmailService
{
    private readonly ILogger<BrevoEmailService> _logger;
    private readonly string _senderEmail;
    private readonly string _recipientEmail;

    public BrevoEmailService(IConfiguration configuration, ILogger<BrevoEmailService> logger)
    {
        _logger = logger;

        _senderEmail = configuration["Brevo:SenderEmail"]
            ?? throw new InvalidOperationException("Brevo sender email is not configured.");
        _recipientEmail = configuration["Brevo:RecipientEmail"]
            ?? throw new InvalidOperationException("Brevo recipient email is not configured.");

        var apiKey = configuration["Brevo:ApiKey"]
            ?? throw new InvalidOperationException("Brevo API key is not configured.");

        Configuration.Default.ApiKey["api-key"] = apiKey;
    }

    public async Task<bool> SendContactFormEmailAsync(string name, string email, string message)
    {
        var apiInstance = new TransactionalEmailsApi();

        var sendSmtpEmail = new SendSmtpEmail(
            sender: new SendSmtpEmailSender("Portfolio Contact Form", _senderEmail),
            to:
            [
                new(_recipientEmail, "Abbie")
            ],
            subject: $"Portfolio Contact: Message from {name}",
            htmlContent: $@"
                <h2>New Contact Form Submission</h2>
                <p><strong>Name:</strong> {name}</p>
                <p><strong>Email:</strong> {email}</p>
                <p><strong>Message:</strong></p>
                <p>{message.Replace("\n", "<br>")}</p>
            ",
            replyTo: new SendSmtpEmailReplyTo(email, name)
        );

        try
        {
            await apiInstance.SendTransacEmailAsync(sendSmtpEmail);
            _logger.LogInformation("Contact form email sent successfully from {SenderEmail} ({SenderName})", email, name);
            return true;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to send contact form email from {Email} ({Name}). Sent using {SenderEmail}", email, name, _senderEmail);
            return false;
        }
    }
}
