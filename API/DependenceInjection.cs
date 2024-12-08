using System.Diagnostics;
using Application.Interfaces;
using Application.Services;

namespace API;

public static class DependenceInjection
{
    public static IServiceCollection AddWebAPIService(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddHealthChecks();
        services.AddSingleton<Stopwatch>();
        services.AddScoped<IClaimsService, ClaimsService>();
        services.AddHttpContextAccessor();
        return services;
    }
}