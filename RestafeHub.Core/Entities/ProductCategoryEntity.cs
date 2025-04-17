using RestafeHub.Core.Common;

namespace RestafeHub.Core.Entities
{
    public class ProductCategoryEntity: AuditEntity
    {
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public Guid? ImageId { get; set; }
        public ImagesEntity? Image { get; set; }
    }
}
