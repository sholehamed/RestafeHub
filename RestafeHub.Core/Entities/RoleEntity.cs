using RestafeHub.Core.Common;

namespace RestafeHub.Core.Entities
{
    public class RoleEntity:EntityBase
    {
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public ICollection<RoleClaimEntity>? RoleClaims { get; set; }
    }
}
