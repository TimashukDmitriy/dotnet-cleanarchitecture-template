namespace DefaultNamespace;

public static class DependencyInjections
{
    public static IServiceCollection AddApiServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }

    public static WebApplication UseApiServices(
        this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();

        app.MapGet("/", () => "Hello World!");

        return app; 
    }
}