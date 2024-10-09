using ExtensionMethod.Endpoints.Extensions.Swagger.Extentions;

namespace ExtensionMethod.Endpoints.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwagger(configuration, "Swagger");

        return services;
    }
}
