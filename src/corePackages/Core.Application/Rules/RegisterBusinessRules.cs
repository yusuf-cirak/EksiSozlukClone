using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Application.Rules;

public static class RegisterBusinessRules
{
    public static IServiceCollection AddSubClassesOfType(this IServiceCollection services,Assembly assembly,Type type,Func<IServiceCollection,Type,IServiceCollection>? addWithLifeCycle=null)
    {
        var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t);

        if (addWithLifeCycle is null)
        {
            foreach (Type businessRuleType in types)
            {
                services.AddScoped(businessRuleType);
            }
        }
        else
        {
            foreach (Type businessRuleType in types)
            {
                addWithLifeCycle(services, businessRuleType);
            }
        }


        return services;

    }
}