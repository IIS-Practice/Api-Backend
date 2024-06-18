using IIS.API.Presentation.Common.OptionsSetup;
using IIS.API.Presentation.Common.Swagger;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Reflection;

namespace IIS.API.Presentation;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentationServices(this IServiceCollection services)
    {
        services.ConfigureOptions();

        services.AddControllers(options =>
        {
            options.Conventions.Add(new RouteTokenTransformerConvention(
                                         new SlugifyParameterTransformer()));
        });

        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }

    public static IServiceCollection ConfigureOptions(this IServiceCollection services)
    {
        // KEEP launchSettings.json and applicatoinSettings.json in SYNC
        services.ConfigureOptions<WWWRootOptionsSetup>();

        return services;
    }
}

