namespace RestafeHub.Core.Common
{
    public class EntityBase
    {
        public Guid Id { get;private set; }
        public bool IsDeleted { get; private set; }
        public Guid CreateBy { get; private set; }
        public DateTime CreateAt { get; private set; }
        public Guid? ModifiedBy { get; private set; }
        public DateTime? ModifiedAt { get; private set; }
    }
    public class AuditEntity:EntityBase
    {
        public bool IsDeleted { get; private set; }
        public Guid? DeletedBy { get; private set; }
        public DateTime? DeletedAt { get; private set; }
        public Guid CreateBy { get; private set; }
        public DateTime CreateAt { get; private set; }
        public Guid? ModifiedBy { get; private set; }
        public DateTime? ModifiedAt { get; private set; }
        public void Delete(Guid userId)
        {
            DeletedBy=userId;
            DeletedAt=DateTime.Now;
            IsDeleted=true;
        }
        public void Update(Guid userId)
        {
            {
                DeletedBy = userId;
                DeletedAt = DateTime.Now;
            }
        }
        public void Create(Guid userId)
        {
            {
                CreateBy = userId;
                CreateAt = DateTime.Now;
            }
        }
    }
}
