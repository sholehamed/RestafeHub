using RestafeHub.Abstraction.Common;

namespace RestafeHub.Abstraction.Interfaces
{
    public interface IDataRepository<T> where T:class,IBaseEntity
    {
        IQueryable<T> Query();
        Task AddAsync(T entity, CancellationToken cancellationToken = default);
        Task UpdateAsync(T entity, CancellationToken cancellationToken = default);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
