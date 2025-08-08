using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using RestafeHub.Business.Abstraction.Common;
using RestafeHub.Business.Abstraction.Interfaces;
using RestafeHub.Business.Interfaces;
using RestafeHub.Business.Util;
using RestafeHub.Domain.Common;

namespace RestafeHub.Business.Services
{
    internal class BaseService<T, C, U, D> : IBaseService<C, U, D> where T : class, IBaseEntity
    {
        private readonly IAppDbContext _context;
        private readonly IMapper _mapper;
        private readonly DbSet<T> _dbSet;
        public BaseService(IAppDbContext context, IMapper mapper)
        {
            _context = context;
            this._mapper = mapper;
            _dbSet = _context.Set<T>();
        }

        public virtual async Task CreateAsync(C createParameter)
        {
            T entity = _mapper.Map<T>(createParameter);
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            T? entity = await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
            if (entity is T e)
                _dbSet.Remove(e);
            await _context.SaveChangesAsync();
        }

        public async Task<D> GetAsync(Guid id)
        {
            D? res = await _dbSet.Where(x => x.Id == id).ProjectTo<D>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
            if (res is D d)
                return d;
            else
                throw new Exception("not found");
        }

        public async Task<PagedList<D>> ListAsync(GetParameter parameter)
        {
            int count = _dbSet.ApplyFilters(parameter.Filter).Select(x => 1).Count();
            var TRes = await _dbSet.ApplyFilters(parameter.Filter)
                 .Take(parameter.PageSize)
                 .Skip((parameter.Page - 1) * parameter.PageSize)
                 .ProjectTo<D>(_mapper.ConfigurationProvider).ToListAsync();
            return new PagedList<D>(TRes, parameter.Page, parameter.PageSize, count);
        }

        public async Task UpdateAsync(Guid id, U updateParameter)
        {
            T? oldEntity = await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
            if (oldEntity is T e)
            {
                oldEntity = _mapper.Map<T>(updateParameter);
                await _context.SaveChangesAsync();
            }
        }
    }
}
