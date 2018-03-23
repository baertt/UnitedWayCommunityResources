using Microsoft.EntityFrameworkCore;

namespace _340_Framework
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Models.Organization> Organization { get; set; }
        public DbSet<Resources> Resources { get; set; }
    }
}