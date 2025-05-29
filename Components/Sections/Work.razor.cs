using AbbiePortfolio.Models;

namespace AbbiePortfolio.Components.Sections;

public partial class Work
{
    private List<ProjectModel> projects = new()
    {
        new ProjectModel
        {
            Title = "E-Commerce Platform",
            Description = "A full-featured online shopping platform built with Blazor Server and Entity Framework Core. Features include user authentication, shopping cart, and payment integration.",
            ImageUrl = "https://via.placeholder.com/400x200",
            PreviewUrl = "https://example.com",
            GithubUrl = "https://github.com/yourusername/ecommerce"
        },
        new ProjectModel
        {
            Title = "Task Management System",
            Description = "A collaborative task management application with real-time updates using SignalR. Includes project boards, team collaboration, and progress tracking.",
            ImageUrl = "https://via.placeholder.com/400x200",
            PreviewUrl = "https://example.com",
            GithubUrl = "https://github.com/yourusername/taskmanager"
        },
        new ProjectModel
        {
            Title = "Weather Dashboard",
            Description = "A responsive weather dashboard that displays real-time weather data and forecasts. Built with Blazor WebAssembly and integrates with weather APIs.",
            ImageUrl = "https://via.placeholder.com/400x200",
            PreviewUrl = "https://example.com",
            GithubUrl = "https://github.com/yourusername/weather"
        }
    };
}
