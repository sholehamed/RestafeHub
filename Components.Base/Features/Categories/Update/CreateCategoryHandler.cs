using MediatR;

namespace Components.Base.Features.Categories.UpdateCategory
{
    internal class CreateCategoryHandler : IRequestHandler<UpdateCategoryCommand, Guid>
    {
        public Task<Guid> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
