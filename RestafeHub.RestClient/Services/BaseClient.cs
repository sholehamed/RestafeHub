using RestafeHub.Business.Abstraction.Common;
using RestafeHub.Business.Abstraction.Interfaces;
using System.Net.Http.Json;

namespace RestafeHub.RestClient.Services
{
    internal class BaseClient<C, U, D> : IBaseService<C, U, D>
    {
        private readonly HttpClient _httpClient;
        private readonly string _route;

        public BaseClient(HttpClient httpClient,string route)
        {
            _httpClient = httpClient;
            _route = route;
        }

        public async Task CreateAsync(C createParameter)
        {
            try
            {
                await _httpClient.PostAsJsonAsync(_route, createParameter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteAsync(Guid id)
        {
            try
            {
                await _httpClient.DeleteAsync($"{_route}/{id}");
            }
            catch (Exception )
            {

                throw;
            }
        }

        public async Task<D> GetAsync(Guid id)
        {
            try
            {
                D? res = await _httpClient.GetFromJsonAsync<D>($"{_route}/{id}");
                if (res is D d)
                    return d;
                throw new Exception("not found");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<PagedList<D>> ListAsync(GetParameter parameter)
        {
            try
            {
                PagedList<D>? res = await _httpClient.GetFromJsonAsync<PagedList<D>>($"{_route}?{parameter.ToString()}");
                if (res is PagedList<D> d)
                    return d;
                return new PagedList<D>(new List<D>(), 0, 0, 0);
            }
            catch (Exception)
            {

                throw ;
            }
        }

        public async Task UpdateAsync(Guid id, U updateParameter)
        {
            try
            {
                await _httpClient.PutAsJsonAsync(_route, updateParameter);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
