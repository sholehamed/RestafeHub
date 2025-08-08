using RestafeHub.Business.Abstraction.Interfaces;
using RestafeHub.Shared.Models;

namespace RestafeHub.RestClient.Services
{
    internal class ProductClient : BaseClient<ProductCreateParameter, ProductUpdateParameter, ProductDto>, IProductService
    {
        public ProductClient(HttpClient httpClient, string route) : base(httpClient, route)
        {
        }
    }
}
