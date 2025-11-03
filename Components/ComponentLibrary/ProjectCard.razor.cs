using Microsoft.AspNetCore.Components;

namespace AbbiePortfolio.Components.ComponentLibrary;

public partial class ProjectCard
{
    [Parameter]
    public required string ImageUrl { get; set; }

    [Parameter]
    public required string Title { get; set; }

    [Parameter]
    public required string Description { get; set; }

    [Parameter]
    public required string PreviewUrl { get; set; }

    [Parameter]
    public required string GithubUrl { get; set; }

}
