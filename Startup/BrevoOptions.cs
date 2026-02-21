namespace AbbiePortfolio.Startup;

public class BrevoOptions
{
    public const string SectionName = "Brevo";
    public required string ApiKey { get; set; }
    public required string SenderEmail { get; set; }
    public required string RecipientEmail { get; set; }
}
