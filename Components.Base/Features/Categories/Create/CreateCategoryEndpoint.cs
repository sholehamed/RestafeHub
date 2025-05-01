using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Components.Base.Features.Categories.CreateCategory
{
    public static class CreateCategoryEndpoint
    {
        public static IEndpointRouteBuilder MapCreateCategory(this IEndpointRouteBuilder routes)
        {
            routes.MapPost("/", async (CreateCategoryCommand cmd, ISender sender) =>
            {
                var id = await sender.Send(cmd);
                return Results.Created($"/{id}", id);
            })
            .WithName("CreateProduct")
            .WithOpenApi(); // Swagger support
            return routes;
        }
    }
}
