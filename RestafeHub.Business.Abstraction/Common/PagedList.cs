namespace RestafeHub.Business.Abstraction.Common
{
    public record PagedList<T>(List<T> Items, int pageNumber, int pageSize, int TotalItems)
    {

    }
}
