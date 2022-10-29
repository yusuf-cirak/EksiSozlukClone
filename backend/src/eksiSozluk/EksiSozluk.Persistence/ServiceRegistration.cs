using System.Reflection;
using Core.Persistence;
using Core.Persistence.Repositories;
using EksiSozluk.Application.Abstractions.Repositories;
using EksiSozluk.Persistence.Contexts;
using EksiSozluk.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EksiSozluk.Persistence;

public static class ServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<BaseDbContext>(opt =>
        {
            opt.UseSqlServer(configuration.GetConnectionString("EksiSozlukSqlServer"), sqlOpt =>
            {
                sqlOpt.EnableRetryOnFailure();
            });
        });
        
        services.AddRepositoryServices(Assembly.GetExecutingAssembly(), typeof(EfRepositoryBase<,>));

        return services;
    }
}