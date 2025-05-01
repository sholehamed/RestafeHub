using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Components.Attendance.Features.UserAttendance
{
    public static class RegisterFeature
    {
        public static void MapUserAttendanceEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapGroup("UserAttendance").WithTags("UserAttendance");
        }
    }
}
