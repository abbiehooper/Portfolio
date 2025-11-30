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
            PreviewUrl = "https://example.com",
            GithubUrl = "https://github.com/abbiehooper/PolicyChatbot"
        },
        new Project
        {
            Title = "Task Management System",
            Description = "A collaborative task management application with real-time updates using SignalR. Includes project boards, team collaboration, and progress tracking.",
            ImageUrl = "https://via.placeholder.com/400x200",
            PreviewUrl = "https://example.com",
            GithubUrl = "https://github.com/yourusername/taskmanager"
        },
        new Project
        {
            Title = "Weather Dashboard",
            Description = "A responsive weather dashboard that displays real-time weather data and forecasts. Built with Blazor WebAssembly and integrates with weather APIs.",
            ImageUrl = "https://via.placeholder.com/400x200",
            PreviewUrl = "https://example.com",
            GithubUrl = "https://github.com/yourusername/weather"
        }
    ];
}
