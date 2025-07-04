namespace RestafeHub.Abstraction.Interfaces
{
    public interface IAuthService
    {
        Guid? GetUserId();
        Guid? GetTenantId();
    }
}
