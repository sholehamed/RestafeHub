using RestafeHub.Core.Common;

namespace RestafeHub.Core.Entities
{
    public class UserEntity:AuditEntity
    {
        public Guid CustomerId { get; set; }
        public CustomerEntity? Customer { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public UserEntity()
        {
            
        }
    }
}
