using RestafeHub.Business.Abstraction.Common;

namespace RestafeHub.Business.Abstraction.Interfaces
{
    public interface IBaseService<C,U,D>
    {
        Task CreateAsync(C createParameter);
        Task UpdateAsync(Guid id,U updateParameter);
        Task DeleteAsync(Guid id);
        Task<PagedList<D>> ListAsync(GetParameter parameter);
        Task<D> GetAsync(Guid id);
    }
}
