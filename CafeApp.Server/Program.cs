
using Scalar.AspNetCore;
using CafeApp.ApiServer.Util;
namespace CafeApp.Server;

public class Program
{
    public static void Main(string[] args)
    {
#if DEBUG

            Components.Attendance.RegisterComponent c1 = new Components.Attendance.RegisterComponent();
            Components.Base.RegisterComponent c2 = new Components.Base.RegisterComponent();

#endif
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllers();
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();
#if DEBUG
            c1.RegisterDependencies(builder.Services);
            c2.RegisterDependencies(builder.Services);
#else
        builder.Services.RegisterServices();

#endif
        var app = builder.Build();
#if DEBUG
            c1.RegisterEndPoints(app);
            c2.RegisterEndPoints(app);
#else
        app.RegisterComponents();

#endif

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapScalarApiReference("");
            app.MapOpenApi();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }


}