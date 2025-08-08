using RestafeHub.Domain.Common;

namespace RestafeHub.Domain.Entities
{
    public class ProductEntity:ActivableEntity
    {
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public virtual ProductCategoryEntity? Category { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        public virtual ICollection<PriceChangeLogEntity>? PriceLog { get; set; }
        public decimal? Stock { get; set; }
    }
}