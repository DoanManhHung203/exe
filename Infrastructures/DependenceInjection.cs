using Application;
using Application.Interfaces;
using Infrastructures.Mappers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Services.Services;

namespace Infrastructures;

public static class DenpendencyInjection
{
    public static IServiceCollection AddInfrastructuresService(this IServiceCollection services, string databaseConnection)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddSingleton<ICurrentTime, CurrentTime>();

        services.AddDbContext<AppDbContext>(option => option.UseSqlServer(databaseConnection));

        services.AddAutoMapper(typeof(MapperConfigurationProfile).Assembly);

        return services;
    }
}