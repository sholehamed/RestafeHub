using RestafeHub.Core.Common;

namespace RestafeHub.Core.Entities
{
    public class CustomerEntity: AuditEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get{ return $"{FirstName} {LastName}"; } }
        public Gender Gender { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime? Birthday { get; set; }
        public int Visits { get; set; }
        public decimal TotalPay { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
