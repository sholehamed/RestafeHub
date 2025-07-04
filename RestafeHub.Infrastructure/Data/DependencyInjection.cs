using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using RestafeHub.Abstraction.Common;
using RestafeHub.Infrastructure.Data.Contexts;
using RestafeHub.Infrastructure.Data.Util;
using System.Linq.Expressions;
using System.Reflection;

namespace RestafeHub.Infrastructure.Data
{
    public static class DependencyInjection
    {
        public class ModulesModelConfigurator : IModelCustomizer
        {
            public void Customize(ModelBuilder modelBuilder, DbContext context)
            {
                var assemblies = AppDomain.CurrentDomain.GetAssemblies();
                var f = Directory.GetFiles(AppContext.BaseDirectory).Where(x => x.Contains("Modules"));
                Console.WriteLine("custom");

                foreach (var item in f)
                {
                    if (item.Contains(".dll"))
                    {
                        var a= Assembly.LoadFile(item);
                        modelBuilder.ApplyConfigurationsFromAssembly(a);
                    }
                }
                foreach (var entityType in modelBuilder.Model.GetEntityTypes())
                {
                    if (!typeof(IBaseEntity).IsAssignableFrom(entityType.ClrType)) continue;

                    var builder = modelBuilder.Entity(entityType.ClrType);

                    // Shadow properties
                    builder.Property<Guid>("TenantId");
                    builder.Property<bool>("IsDeleted");
                    builder.Property<Guid>("CreatedBy");
                    builder.Property<Guid?>("DeletedBy").IsRequired(false);
                    builder.Property<Guid?>("ModifiedBy").IsRequired(false);
                    builder.Property<DateTime>("CreatedAt");
                    builder.Property<DateTime?>("ModifiedAt").IsRequired(false);
                    builder.Property<DateTime?>("DeletedAt").IsRequired(false);

                    // Global filter: IsDeleted == false && TenantId == currentTenant
                    builder.HasQueryFilter(CreateSoftDeleteExpression(entityType.ClrType));
                }
            }
            private LambdaExpression CreateSoftDeleteExpression(Type entityType)
            {
                var parameter = Expression.Parameter(entityType, "e");

                var isDeletedExpr = Expression.Equal(
                    Expression.Call(
                        typeof(EF),
                        nameof(EF.Property),
                        new[] { typeof(bool) },
                        parameter,
                        Expression.Constant("IsDeleted")
                    ),
                    Expression.Constant(false)
                );

                return Expression.Lambda(isDeletedExpr, parameter);
            }

        }

        public static IServiceCollection RegisterInfrastructure(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<AuditInterceptor>();
            services.AddDbContext<ApplicationDbContext>((sp, options) =>
             {
                 var interceptor = sp.GetRequiredService<AuditInterceptor>();
                 options
                     .UseSqlServer(connectionString).ReplaceService<IModelCustomizer, ModulesModelConfigurator>()
                     .AddInterceptors(interceptor);
             });
            return services;
        }
    }
}
