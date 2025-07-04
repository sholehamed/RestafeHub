using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using RestafeHub.Abstraction.Common;
using RestafeHub.Abstraction.Interfaces;

namespace RestafeHub.Infrastructure.Data.Util
{
    public class AuditInterceptor : SaveChangesInterceptor
    {
        private readonly IAuthService _auth;

        public AuditInterceptor(IAuthService auth)
        {
            _auth = auth;
        }

        public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
        {
            var context = eventData.Context;
            if (context is null) return result;

            var now = DateTime.UtcNow;
            var userId = _auth.GetUserId();
            var tenantId = _auth.GetTenantId();

            foreach (var entry in context.ChangeTracker.Entries().Where(e => e.Entity is BaseEntity))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("TenantId").CurrentValue = tenantId;
                    entry.Property("IsDeleted").CurrentValue = false;
                    entry.Property("CreatedAt").CurrentValue = now;
                    entry.Property("CreatedBy").CurrentValue = userId;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("ModifiedAt").CurrentValue = now;
                    entry.Property("ModifiedBy").CurrentValue = userId;
                }

                if (entry.State == EntityState.Deleted)
                {
                    entry.State = EntityState.Modified;
                    entry.Property("IsDeleted").CurrentValue = true;
                    entry.Property("DeletedAt").CurrentValue = now;
                    entry.Property("DeletedBy").CurrentValue = userId;
                }
            }

            return result;
        }
    }
}
