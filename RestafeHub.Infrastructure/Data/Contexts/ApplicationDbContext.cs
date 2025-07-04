using Microsoft.EntityFrameworkCore;
using RestafeHub.Abstraction.Common;
using RestafeHub.Abstraction.Interfaces;
using System.Linq.Expressions;

namespace RestafeHub.Infrastructure.Data.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IAuthService _auth;

        public ApplicationDbContext(DbContextOptions options, IAuthService auth) : base(options)
        {
            
            Database.EnsureCreated();
            _auth=auth;
        }



       
    }
}
