using IIS.API.Presentation.Common.OptionsSetup;
using IIS.API.Presentation.Common.Swagger;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Serilog;
using Serilog.Events;
using System.Reflection;

namespace IIS.API.Presentation;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentationServices(this IServiceCollection services)
    {
        services.ConfigureSerilog();

        services.ConfigureOptions();

        services.AddControllers(options =>
        {
            options.Conventions.Add(new RouteTokenTransformerConvention(
                                         new SlugifyParameterTransformer()));
        });

        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddCors(options =>
         {
             options.AddDefaultPolicy(builder =>
             {
                 builder.AllowAnyOrigin()
                     .AllowAnyMethod()
                     .AllowAnyHeader();
             });
         });

        return services;
    }

    private static IServiceCollection ConfigureOptions(this IServiceCollection services)
    {
        // KEEP launchSettings.json and applicatoinSettings.json in SYNC
        services.ConfigureOptions<WWWRootOptionsSetup>();

        return services;
    }

    private static IServiceCollection ConfigureSerilog(this IServiceCollection services)
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
            .MinimumLevel.Override("Microsoft.Hosting.Lifetime", LogEventLevel.Information)
            .MinimumLevel.Override("System", LogEventLevel.Information)
            .WriteTo.Console()
            .WriteTo.Logger(lc => lc
                .Filter.ByIncludingOnly(logEvent => logEvent.Level == LogEventLevel.Information || logEvent.Level == LogEventLevel.Fatal)
                .WriteTo.File("logs/info.log", rollOnFileSizeLimit: true, fileSizeLimitBytes: 1 * 1024 * 1024)) //1MB
            .WriteTo.Logger(lc => lc
                .Filter.ByIncludingOnly(logEvent => logEvent.Level == LogEventLevel.Warning)
                .WriteTo.File("logs/warning.log", LogEventLevel.Warning, rollOnFileSizeLimit: true, fileSizeLimitBytes: 1 * 1024 * 1024, shared: true))
            .WriteTo.Logger(lc => lc
                .Filter.ByIncludingOnly(logEvent => logEvent.Level == LogEventLevel.Error)
                .WriteTo.File("logs/error.log", LogEventLevel.Error, rollOnFileSizeLimit: true, fileSizeLimitBytes: 1 * 1024 * 1024, shared: true))
            .CreateLogger();

        services.AddSerilog();

        return services;
    }
}

