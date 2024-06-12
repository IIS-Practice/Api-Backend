using IIS.API.Domain.Abstractions;
using IIS.API.Infrastructure.Repositories;
using IIS.API.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace IIS.API.Presentation;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentationServices(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }
}

