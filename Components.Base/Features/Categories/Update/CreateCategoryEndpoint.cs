using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Components.Base.Features.Categories.UpdateCategory
{
    public static class UpdateCategoryEndpoint
    {
        public static IEndpointRouteBuilder MapUpdateCategory(this IEndpointRouteBuilder routes)
        {
            routes.MapPut("/", async (UpdateCategoryCommand cmd, ISender sender) =>
            {
                var id = await sender.Send(cmd);
                return Results.Created($"/{id}", id);
            })
            .WithName("UpdateProduct")
            .WithOpenApi(); // Swagger support
            return routes;
        }
    }
}
