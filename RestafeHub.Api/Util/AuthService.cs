using RestafeHub.Abstraction.Interfaces;

namespace RestafeHub.Api.Util
{
    public class AuthService : IAuthService
    {
        public Guid? GetTenantId()
        {
            return Guid.Empty;
        }

        public Guid? GetUserId()
        {
            return Guid.Empty;  
        }
    }
}
