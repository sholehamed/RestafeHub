using RestafeHub.Shared.Models;

namespace RestafeHub.Business.Abstraction.Interfaces
{
    public interface IProductCategoryService:IBaseService<ProductCategoryCreateParameter,ProductCategoryUpdateParameter,ProductCategoryDto>
    {
    }
}
