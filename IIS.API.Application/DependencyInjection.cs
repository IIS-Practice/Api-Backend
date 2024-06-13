using IIS.API.Application.Services.FaqService;
using IIS.API.Application.Services.UserService;
using Microsoft.Extensions.DependencyInjection;

namespace IIS.API.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IFaqService, FaqService>();   
        services.AddScoped<IUserService, UserService>();

        return services;
    }
}
