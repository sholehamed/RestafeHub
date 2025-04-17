using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace RestafeHub.Core.Interfaces
{
    public interface IModule
    {
        void RegisterDependencies(IServiceCollection services);
        public void RegisterEndPoints(IEndpointRouteBuilder builder);
    }
}
