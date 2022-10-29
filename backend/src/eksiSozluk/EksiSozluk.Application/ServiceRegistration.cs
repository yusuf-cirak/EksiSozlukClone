using System.Reflection;
using Core.Application;
using Core.Application.Rules;
using Microsoft.Extensions.DependencyInjection;

namespace EksiSozluk.Application;

public static class ServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddBusinessRuleServices(Assembly.GetExecutingAssembly(), typeof(BaseBusinessRules));
        return services;
    }
}