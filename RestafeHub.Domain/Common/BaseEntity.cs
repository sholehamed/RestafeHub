namespace RestafeHub.Domain.Common
{
    public interface IBaseEntity
    {
        DateTime DeletedAt { get; }
        Guid Id { get; }
        bool IsDeleted { get; }
    }
    public class BaseEntity : IBaseEntity
    {
        public Guid Id { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime DeletedAt { get; private set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }

    public interface IActivableEntity:IBaseEntity
    {
        DateTime? DiactivedAt { get; set; }
        bool IsActive { get; set; }
    }

    public class ActivableEntity : BaseEntity, IActivableEntity
    {
        public bool IsActive { get; set; }
        public DateTime? DiactivedAt { get; set; }
    }
}
