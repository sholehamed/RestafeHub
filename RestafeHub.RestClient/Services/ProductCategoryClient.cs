using RestafeHub.Business.Abstraction.Interfaces;
using RestafeHub.Shared.Models;

namespace RestafeHub.RestClient.Services
{
    internal class ProductCategoryClient : BaseClient<ProductCategoryCreateParameter, ProductCategoryUpdateParameter, ProductCategoryDto>, IProductCategoryService
    {
        public ProductCategoryClient(HttpClient httpClient, string route) : base(httpClient, route)
        {
        }
    }
}
