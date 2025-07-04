namespace RestafeHub.Abstraction.Common
{
    public class Comparable<T>
    {
        public string? Operator { get; set; } // eq, ne, lt, gt, lte, gte
        public T? Value { get; set; }
    }
}
