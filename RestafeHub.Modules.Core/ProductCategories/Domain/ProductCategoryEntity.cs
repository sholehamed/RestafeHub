using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestafeHub.Abstraction.Common;

namespace RestafeHub.Modules.Core.ProductCategories.Domain
{
    public class ProductCategoryEntity:BaseEntity
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
    public class ProductCategoryConfig : IEntityTypeConfiguration<ProductCategoryEntity>
    {
        public void Configure(EntityTypeBuilder<ProductCategoryEntity> builder)
        {
            builder.ToTable("productCategory");
        }
    }
}
