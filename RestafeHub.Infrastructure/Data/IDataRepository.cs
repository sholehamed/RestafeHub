using Microsoft.EntityFrameworkCore;
using RestafeHub.Abstraction.Common;
using RestafeHub.Abstraction.Interfaces;
using RestafeHub.Infrastructure.Data.Contexts;

namespace RestafeHub.Infrastructure.Data
{
    internal class DataRepository<TEntity> : IDataRepository<TEntity> where TEntity : class, IBaseEntity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<TEntity> _entities;

        public DataRepository(ApplicationDbContext context)
        {
            _context=context;
            _entities=_context.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            await _entities.AddAsync(entity, cancellationToken);
        }

        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var entity = await _entities.FindAsync(id, cancellationToken);
            if (entity != null)
                _entities.Remove(entity);
        }



        public IQueryable<TEntity> Query()
        {
            return _entities.AsNoTracking();
        }

        public async Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            var oldEntity = await _entities.FindAsync(entity.Id, cancellationToken);
            if (oldEntity != null)
                oldEntity=entity;
        }
    }
}
