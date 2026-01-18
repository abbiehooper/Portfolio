using AbbiePortfolio.Models;

namespace AbbiePortfolio.Components.Sections;

public partial class Projects
{
    private List<Project> projects =
    [
        new Project
        {
            Title = "Policy Expert",
            Description = "AI-powered insurance policy chatbot that answers questions about policy documents using Claude API with intelligent citation tracking and cost-optimized prompt caching.",
            ImageUrl = "/images/Projects/PolicyChatbot.png",
            PreviewUrl = "https://policy-expert-wydkh.ondigitalocean.app/",
            GithubUrl = "https://github.com/abbiehooper/PolicyChatbot"
        },
        new Project
        {
            Title = "Survey Hub",
            Description = "A .NET 8 Blazor web application for uploading, managing, and analyzing surveys. Built with MudBlazor for a modern Material Design UI.",
            ImageUrl = "/images/Projects/DeveloperExperience.png",
            GithubUrl = "https://github.com/abbiehooper/DeveloperExperience"
        },

    ];
}
