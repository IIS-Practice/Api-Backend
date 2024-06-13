﻿using IIS.API.Application.Services.FaqService;
using IIS.API.Application.Services.UserService;
using IIS.API.Application.Services.ServiceService;
using Microsoft.Extensions.DependencyInjection;

namespace IIS.API.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IFaqService, FaqService>();   
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IServiceService, ServiceService>();

        return services;
    }
}
