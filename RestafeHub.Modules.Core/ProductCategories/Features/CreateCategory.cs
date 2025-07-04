using MediatR;
using RestafeHub.Modules.Core.ProductCategories.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestafeHub.Modules.Core.ProductCategories.Features
{
    public record CreateProductCategoryCommand(ProductCategoryDto Dto) : IRequest<Guid>;

    public class CreateProductCategoryHandler : IRequestHandler<CreateProductCategoryCommand, Guid>
    {
        private readonly IGenericRepository<ProductCategoryEntity> _repo;

        public CreateProductCategoryHandler(IGenericRepository<ProductCategoryEntity> repo)
        {
            _repo = repo;
        }

        public async Task<Guid> Handle(CreateProductCategoryCommand request, CancellationToken cancellationToken)
        {
            var entity = new ProductCategoryEntity
            {
                Id = Guid.NewGuid(),
                Name = request.Dto.Name,
                IsActive = request.Dto.IsActive
            };

            await _repo.AddAsync(entity, cancellationToken);
            return entity.Id;
        }
    }
}
