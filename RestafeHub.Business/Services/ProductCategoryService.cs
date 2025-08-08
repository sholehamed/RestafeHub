using AutoMapper;
using RestafeHub.Business.Abstraction.Interfaces;
using RestafeHub.Business.Interfaces;
using RestafeHub.Domain.Entities;
using RestafeHub.Shared.Models;

namespace RestafeHub.Business.Services
{
    internal class ProductCategoryService : BaseService<ProductCategoryEntity, ProductCategoryCreateParameter, ProductCategoryUpdateParameter, ProductCategoryDto>, IProductCategoryService
    {
        public ProductCategoryService(IAppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
