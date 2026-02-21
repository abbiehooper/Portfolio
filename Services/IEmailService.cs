namespace AbbiePortfolio.Services;

public interface IEmailService
{
    Task<bool> SendContactFormEmailAsync(string name, string email, string message);
}
