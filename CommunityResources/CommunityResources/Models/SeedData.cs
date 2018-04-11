using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace CommunityResources.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Data.CommunityResourcesContext(
                serviceProvider.GetRequiredService<DbContextOptions<Data.CommunityResourcesContext>>()))
            {
                // Look for any movies.
                if (context.Organizations.Any())
                {
                    Console.WriteLine("Seeded1");
                    return;   // DB has been seeded
                }

                context.Organizations.AddRange(
                    new Organization
                    {
                        Id = 00,
                        Name = "Test",
                        
                    }
                    
                );
                context.SaveChanges();
                Console.WriteLine("Seeded2");
            }
        }
    }
}