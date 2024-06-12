using IIS.API.Domain.Abstractions;
using IIS.API.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IIS.API.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, 
                                                                IConfiguration configuration)
    {
        string connectionString = configuration.GetConnectionString("DefaultConnection")
                                                    ?? throw new ArgumentNullException("Не найдена строка подключения к базе данных");

        services.AddDbContext<ApplicationDbContext>(cfg => cfg.UseSqlServer(connectionString));

        services.AddScoped<IFaqRepository, FaqRepository>();
<<<<<<< HEAD
        services.AddScoped<IReviewRepository, ReviewRepository>();
=======
>>>>>>> ca833e6f962c233dac3e5263e43caf94c355e2d0

        return services;
    }
}