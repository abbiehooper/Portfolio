using AbbiePortfolio.Models;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace AbbiePortfolio.Components.Sections;

public partial class Contact
{
    [Inject] public required ISnackbar Snackbar { get; set; }

    private bool success;
    private bool sending;
    private MudForm? form;
    private ContactModel contactModel = new();

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
            // Simulate email sending delay
            await Task.Delay(2000);

            // Show success message
            Snackbar.Add("Message sent successfully! I'll get back to you soon.", Severity.Success);

            // Reset form
            contactModel = new ContactModel();
            form.ResetValidation();
        }
        catch (Exception ex)
        {
            Snackbar.Add("Failed to send message. Please try again later.", Severity.Error);
        }
        finally
        {
            sending = false;
        }
    }

}
