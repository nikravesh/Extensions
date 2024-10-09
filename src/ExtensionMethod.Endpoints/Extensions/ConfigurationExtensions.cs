using ExtensionMethod.Endpoints.Extensions.Swagger.Extentions;

namespace ExtensionMethod.Endpoints.Extensions;

public static class ConfigurationExtensions
{
    public static WebApplication AddConfigurations(this WebApplication builder)
    {
        builder.UseSwaggerUI("Swagger");

        builder.UseHttpsRedirection();

        builder.UseAuthorization();

        builder.MapControllers();

        return builder;
    }
}
