using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Project1.Data
{
    public class ApplicationDatabaseContext:IdentityDbContext<IdentityUser>
    {
        public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext>options):base(options)
        {
            
        }
    }
}
