using RestafeHub.Domain.Common;

namespace RestafeHub.Domain.Entities
{
    public class ProductCategoryEntity:ActivableEntity
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<ProductEntity>? Products { get; set; }
    }
}
