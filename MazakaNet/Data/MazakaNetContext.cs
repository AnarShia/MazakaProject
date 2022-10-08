using MazakaNet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MazakaNet.Data
{
    public class MazakaNetContext:IdentityDbContext<IdentityUser>
    {
        public MazakaNetContext(DbContextOptions<MazakaNetContext> options) : base(options)
        {
        }
        public DbSet<AppUser> AppUser { get; set; }
    }
}
