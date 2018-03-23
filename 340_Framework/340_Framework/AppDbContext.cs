using Microsoft.EntityFrameworkCore;

namespace _340_Framework
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Organization> Customers { get; set; }
    }
}