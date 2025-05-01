using MediatR;

namespace Components.Base.Features.Categories.CreateCategory
{
    internal record CreateCategoryCommand(string Title,string description):IRequest<Guid>
    {
    }
}
