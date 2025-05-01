using Components.Base.Features.Categories.CreateCategory;
using Components.Base.Features.Categories.UpdateCategory;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Components.Base.Features.Categories
{
    public static class RegisterFeature
    {
        public static void MapCategoryEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapGroup("categories").WithTags("categories")
                .MapCreateCategory()
                .MapUpdateCategory();
        }
    }
}
