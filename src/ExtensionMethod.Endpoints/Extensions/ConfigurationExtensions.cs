using ExtensionMethod.Endpoints.Extensions.Swagger.Extentions;

namespace ExtensionMethod.Endpoints.Extensions;

public static class ConfigurationExtensions
{
    public static WebApplication AddConfigurations(this WebApplication builder)
    {       

        builder.UseHttpsRedirection();

        builder.UseAuthorization();

        builder.MapControllers();

        builder.UseSwaggerUI("Swagger");

        return builder;
    }
}
