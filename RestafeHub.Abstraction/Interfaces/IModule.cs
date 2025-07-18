﻿using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace RestafeHub.Abstraction.Interfaces
{
    public interface IModule
    {
        void RegisterServices(IServiceCollection services, IConfiguration config);
        void MapEndpoints(IEndpointRouteBuilder app);
    }
}
