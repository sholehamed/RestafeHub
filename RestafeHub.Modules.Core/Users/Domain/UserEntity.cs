using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestafeHub.Abstraction.Common;

namespace RestafeHub.Modules.Core.Users.Domain
{
    public class UserEntity:IdentityUser<Guid>, IBaseEntity
    {
    }
    public class UserConfig : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("Users");

        }
    }
}
