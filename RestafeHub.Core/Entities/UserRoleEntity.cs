using RestafeHub.Core.Common;

namespace RestafeHub.Core.Entities
{
    internal class UserRoleEntity: AuditEntity
    {
        public Guid UserId { get; set; }
        public UserEntity? User { get; set; }
        public Guid RoleId { get; set; }
        public RoleEntity? Role { get; set; }
    }
}
