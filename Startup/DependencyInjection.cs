namespace AbbiePortfolio.Startup;

public static class DependencyInjection
{
    public static IServiceCollection SetupDI(this IServiceCollection services) => services
    .AddServices();

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddHttpClient();
        return services;
    }
}
