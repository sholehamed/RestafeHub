using MediatR;

namespace Components.Base.Features.Categories.CreateCategory
{
    internal class CreateCategoryHandler : IRequestHandler<CreateCategoryCommand, Guid>
    {
        public Task<Guid> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
