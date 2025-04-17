using RestafeHub.Core.Common;

namespace RestafeHub.Core.Entities
{
    public class ProductEntity: AuditEntity
    {
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public string? Description { get; set; }
        public Guid? ImageId { get; set; }
        public ImagesEntity? Image { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }


    }
}
