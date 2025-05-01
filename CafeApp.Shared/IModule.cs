using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace CafeApp.Shared
{
    public interface IModule
    {
        void RegisterDependencies(IServiceCollection services);
        public void RegisterEndPoints(IEndpointRouteBuilder builder);
    }
}
