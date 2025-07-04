using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RestafeHub.Abstraction.Interfaces;

namespace RestafeHub.Modules.Core
{
    internal class CoreModule : IModule
    {
        public void MapEndpoints(IEndpointRouteBuilder app)
        {
            throw new NotImplementedException();
        }

        public void RegisterServices(IServiceCollection services, IConfiguration config)
        {
        }
    }
}
