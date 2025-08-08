using AutoMapper;
using RestafeHub.Business.Abstraction.Interfaces;
using RestafeHub.Business.Interfaces;
using RestafeHub.Domain.Entities;
using RestafeHub.Shared.Models;

namespace RestafeHub.Business.Services
{
    internal class ProductService : BaseService<ProductEntity, ProductCreateParameter, ProductUpdateParameter, ProductDto>, IBaseService<ProductCreateParameter, ProductUpdateParameter, ProductDto>
    {
        public ProductService(IAppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
