using IIS.API.Presentation.Common.Swagger;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace IIS.API.Presentation;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentationServices(this IServiceCollection services)
    {
        services.AddControllers(options =>
        {
            options.Conventions.Add(new RouteTokenTransformerConvention(
                                         new SlugifyParameterTransformer()));
        });
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }
}

