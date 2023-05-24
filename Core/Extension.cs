using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace SelectorDemo.Core
{
    public static class Extension
    {
        public static IServiceCollection AddMapper(this IServiceCollection services, params Assembly[] assemblies)
        {
            services.TryAddSingleton<IMapper, Mapper>();

            assemblies ??= AppDomain.CurrentDomain.GetAssemblies();

            var configMapTypes = assemblies
                .SelectMany(a =>
                a.GetTypes()
                .Where(t =>
                t.IsAssignableTo(typeof(IConfigMap))
                && !t.IsAbstract && !t.IsInterface));

            foreach (var configMapType in configMapTypes)
            {
                services.AddTransient(typeof(IConfigMap), configMapType);
            }

            return services;
        }
    }
}