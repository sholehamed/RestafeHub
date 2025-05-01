using CafeApp.Shared;
using System.Reflection;

namespace CafeApp.ApiServer.Util
{
    public static class Extentions
    {
        public static WebApplication RegisterComponents(this WebApplication builder) 
        {
            var moduleFolder = Path.Combine(AppContext.BaseDirectory, "Components");
            var dlls = Directory.GetFiles(moduleFolder, "*.dll");

            foreach (var dllPath in dlls)
            {
                var assembly = Assembly.LoadFrom(dllPath);
                var moduleTypes = assembly.GetTypes()
                    .Where(t => typeof(IModule).IsAssignableFrom(t) && !t.IsInterface);

                foreach (var type in moduleTypes)
                {
                    var module = (IModule)Activator.CreateInstance(type)!;
                    module.RegisterEndPoints(builder);
                }
            }
            return builder;
        }
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            var moduleFolder = Path.Combine(AppContext.BaseDirectory, "Components");
            var dlls = Directory.GetFiles(moduleFolder, "*.dll");

            foreach (var dllPath in dlls)
            {
                var assembly = Assembly.LoadFrom(dllPath);
                var moduleTypes = assembly.GetTypes()
                    .Where(t => typeof(IModule).IsAssignableFrom(t) && !t.IsInterface);

                foreach (var type in moduleTypes)
                {
                    var module = (IModule)Activator.CreateInstance(type)!;
                    module.RegisterDependencies(services);
                }
            }
            return services;
        }
    }
}
