using AbbiePortfolio.Models;
using Microsoft.AspNetCore.Components;
using System.Text.Json;

namespace AbbiePortfolio.Components.Pages;

public partial class Blog
{
    [Inject]
    public required IHttpClientFactory HttpClientFactory { get; set; }

    [Inject]
    public required NavigationManager Navigation { get; set; }

    private List<BlogPost> Blogs = [];

    protected override async Task OnInitializedAsync()
    {
        await LoadBlogPostsAsync();
    }

    private List<BlogPost> GetBlogPosts(string category) => [.. Blogs.Where(blog => blog.Category == category)];

    private async Task LoadBlogPostsAsync()
    {
        try
        {
            using var httpClient = HttpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri(Navigation.BaseUri);
            var json = await httpClient.GetStringAsync("blog.json");
            var blogPosts = JsonSerializer.Deserialize<List<BlogPost>>(json);
            Blogs = blogPosts ?? [];
        }
        catch (Exception ex)
        {
            // Log the exception (ex) as needed
            Console.WriteLine($"Error retrieving blog posts {ex}");
            Blogs = [];
        }
    }
}
