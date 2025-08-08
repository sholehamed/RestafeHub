using RestafeHub.Domain.Common;

namespace RestafeHub.Domain.Entities
{
    public class PriceChangeLogEntity:BaseEntity
    {
        public Guid ProductId { get; set; }
        public virtual ProductEntity? Product { get; set; }
        public long BuyPrice { get; set; }
        public long SellPrice { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
    }
}
