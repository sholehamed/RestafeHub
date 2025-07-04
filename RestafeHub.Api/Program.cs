using RestafeHub.Abstraction.Interfaces;
using RestafeHub.Api.Util;
using RestafeHub.Infrastructure.Data;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers(options =>
{
    options.ModelBinderProviders.Insert(0, new ComparableBinderProvider());
});
List<IModule> Modules = new();
builder.Services.AddScoped<IAuthService,AuthService>();
RegisterModules(builder.Services, builder.Configuration);
builder.Services.RegisterInfrastructure(builder.Configuration.GetConnectionString("RestafeHub")!);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapScalarApiReference("");
    app.MapOpenApi();
}

app.UseHttpsRedirection();


MapModules(app);

app.Run();


void RegisterModules(IServiceCollection services, IConfiguration config)
{
    var moduleTypes = AppDomain.CurrentDomain
        .GetAssemblies()
        .SelectMany(a => a.GetTypes())
        .Where(t => typeof(IModule).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract);

    foreach (var type in moduleTypes)
    {
        if (Activator.CreateInstance(type) is IModule module)
        {
            module.RegisterServices(services, config);
            Modules.Add(module);
        }
    }
}

void MapModules(IEndpointRouteBuilder app)
{
    foreach (var module in Modules)
        module.MapEndpoints(app);
}
