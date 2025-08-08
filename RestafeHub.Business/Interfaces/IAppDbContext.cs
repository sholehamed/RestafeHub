using Microsoft.EntityFrameworkCore;

namespace RestafeHub.Business.Interfaces
{
    public interface IAppDbContext
    {
        public DbSet<T> Set<T>() where T : class;
        public Task SaveChangesAsync();
    }
}
