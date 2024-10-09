namespace ExtensionMethod.Endpoints.Extensions;

public static class ConfigurationExtensions
{
    public static WebApplication AddConfigurations(this WebApplication builder)
    {
        if (builder.Environment.IsDevelopment())
        {
            builder.UseSwagger();
            builder.UseSwaggerUI();
        }

        builder.UseHttpsRedirection();

        builder.UseAuthorization();

        builder.MapControllers();

        return builder;
    }
}
