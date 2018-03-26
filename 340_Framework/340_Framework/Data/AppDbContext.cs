using _340_Framework.Models;
using Microsoft.EntityFrameworkCore;

namespace _340_Framework.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Resources> Resources { get; set; }
        public DbSet<Times> Times { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Organization>().ToTable("Organization");
            modelBuilder.Entity<Resources>().ToTable("Resource");
            modelBuilder.Entity<Times>().ToTable("Time");
        }
    }
}
