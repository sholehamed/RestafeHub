using CafeApp.Shared;
using Components.Attendance.Features.UserAttendance;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace Components.Attendance
{
    public  class RegisterComponent : IModule
    {
        public   void RegisterEndPoints(IEndpointRouteBuilder builder)
        {
            builder.MapUserAttendanceEndpoints();
        }
        public  void  RegisterDependencies(IServiceCollection services)
        {
            services.AddMediatR(x => x.RegisterServicesFromAssembly(typeof(RegisterComponent).Assembly));

        }
    }
}
