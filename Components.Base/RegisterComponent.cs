using CafeApp.Shared;
using Components.Base.Features.Categories;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace Components.Base
{
    public class RegisterComponent : IModule
    {
        public void RegisterEndPoints(IEndpointRouteBuilder builder)
        {
            builder.MapCategoryEndpoints();
        }
        public void RegisterDependencies(IServiceCollection services)
        {
            services.AddMediatR(x => x.RegisterServicesFromAssembly(typeof(RegisterComponent).Assembly));

        }
    }
}
