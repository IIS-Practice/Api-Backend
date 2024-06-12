using IIS.API.Application.Services.FaqService;
using IIS.API.Application.Services.ReviewService;
using Microsoft.Extensions.DependencyInjection;

namespace IIS.API.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IFaqService, FaqService>();   
        services.AddScoped<IReviewService, ReviewService>();   

        return services;
    }
}
