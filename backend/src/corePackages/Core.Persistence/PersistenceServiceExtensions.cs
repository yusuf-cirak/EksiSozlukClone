using System.Reflection;
using Core.CrossCuttingConcerns.Exceptions;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Persistence;

public static class PersistenceServiceExtensions
{
    public static IServiceCollection AddRepositoryServices(this IServiceCollection services, Assembly assembly,
        Type genericType, string interfacePrefix="I")
    {
        Type[] repositories = assembly.GetTypes()
            .Where(t => t.BaseType!.IsGenericType && t.BaseType.GetGenericTypeDefinition() == genericType).ToArray();

        foreach (Type repository in repositories)
        {
            string repositoryName = repository.Name;

            Type? repositoryInterface =
                repository.GetInterfaces().FirstOrDefault(e => e.Name == $"{interfacePrefix}{repositoryName}");

            if (repositoryInterface==null)
            {
                throw new NotFoundException($"Reflection could not find the interface '{interfacePrefix}{repositoryName}' for '{repositoryName}'");
            }
            services.AddScoped(repositoryInterface, repository);
        }

        return services;
    }
}