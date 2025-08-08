namespace RestafeHub.Shared.Models
{
    public class ProductCreateParameter
    {
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public decimal SellPrice { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal? Stock { get; set; }
    }
    public class  ProductUpdateParameter:ProductCreateParameter
    {
        public Guid Id { get; set; }
    }
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        public decimal? Stock { get; set; }
    }
}
