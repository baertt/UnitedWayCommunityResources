using Microsoft.EntityFrameworkCore;

namespace CommunityResources.Models
{
    public class ResourceContext : DbContext
    {
        public ResourceContext(DbContextOptions<ResourceContext> options)
                : base(options)
        {
        }

        public DbSet<Resource> Resource { get; set; }
    }
}