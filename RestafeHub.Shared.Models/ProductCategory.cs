namespace RestafeHub.Shared.Models
{
    public class ProductCategoryCreateParameter
    {
        public string Name { get; set; }
        public string? Description { get; set; }
    }
    public class ProductCategoryUpdateParameter : ProductCategoryCreateParameter
    {
        public Guid Id { get; set; }
    }
    public class ProductCategoryDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }

}
