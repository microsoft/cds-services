using CDSService.Models.Converters;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text.Json;
using System.Text.Json.Serialization;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults(workerApp =>
    {
        workerApp.ConfigureSystemTextJson();
    })
    .Build();

host.Run();

internal static class WorkerConfigurationExtensions
{
    /// <summary>
    /// Calling ConfigureFunctionsWorkerDefaults() configures the Functions Worker to use System.Text.Json for all JSON
    /// serialization and sets JsonSerializerOptions.PropertyNameCaseInsensitive = true;
    /// This method uses DI to modify the JsonSerializerOptions. Call /api/HttpFunction to see the changes.
    /// </summary>
    public static IFunctionsWorkerApplicationBuilder ConfigureSystemTextJson(this IFunctionsWorkerApplicationBuilder builder)
    {
        builder.Services.Configure<JsonSerializerOptions>(jsonSerializerOptions =>
        {
            jsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            jsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
            //jsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;

            // override the default value
            jsonSerializerOptions.PropertyNameCaseInsensitive = false;
            jsonSerializerOptions.Converters.Add(new PatientConverter());
        });

        return builder;
    }

    
}