using MediatR;

namespace Components.Base.Features.Categories.UpdateCategory
{
    internal record UpdateCategoryCommand(string Title,string description):IRequest<Guid>
    {
    }
}
