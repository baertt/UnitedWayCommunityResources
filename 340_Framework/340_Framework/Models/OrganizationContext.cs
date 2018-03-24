using Microsoft.EntityFrameworkCore;

namespace _340_Framework.Models
{
    public class OrganizationContext : DbContext
    {
        public OrganizationContext(DbContextOptions<OrganizationContext> options)
                : base(options)
        {
        }

        public DbSet<Organization> Movie { get; set; }
    }
}
