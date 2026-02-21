using AbbiePortfolio.Services;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace AbbiePortfolio.Components.ComponentLibrary;

public partial class ContactForm
{
    [Inject] public required ISnackbar Snackbar { get; set; }
    [Inject] public required IEmailService EmailService { get; set; }

    private bool success;
    private bool sending;
    private MudForm? form;
    private Models.Contact contactModel = new();

    private bool CanSubmit =>
        !string.IsNullOrWhiteSpace(contactModel.Name) &&
        !string.IsNullOrWhiteSpace(contactModel.Email) &&
        !string.IsNullOrWhiteSpace(contactModel.Message) &&
        success;

    private async Task SendEmail()
    {
        sending = true;

        try
        {
            var sent = await EmailService.SendContactFormEmailAsync(
                contactModel.Name!,
                contactModel.Email!,
                contactModel.Message!
            );

            if (sent)
            {
                Snackbar.Add("Message sent successfully! I'll get back to you soon.", Severity.Success);
                contactModel = new Models.Contact();
                form?.ResetValidation();
            }
            else
            {
                Snackbar.Add("Failed to send message. Please try again later.", Severity.Error);
            }
        }
        catch (Exception)
        {
            Snackbar.Add("Failed to send message. Please try again later.", Severity.Error);
        }
        finally
        {
            sending = false;
        }
    }
}