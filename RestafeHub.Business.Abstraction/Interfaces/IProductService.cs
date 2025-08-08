using RestafeHub.Shared.Models;

namespace RestafeHub.Business.Abstraction.Interfaces
{
    public interface IProductService:IBaseService<ProductCreateParameter,ProductUpdateParameter,ProductDto>
    {
    }
}
