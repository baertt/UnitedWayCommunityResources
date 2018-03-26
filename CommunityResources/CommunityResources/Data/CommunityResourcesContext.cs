using CommunityResources.Models;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityResources.Data
{
    public class CommunityResourcesContext : DbContext
        
    {


        public CommunityResourcesContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Organization> Organizations { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Resource> Resources { get; set; }

        public DbSet<Time> Times { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Organization>().ToTable("Organization");
            modelBuilder.Entity<Contact>().ToTable("Contact");
            modelBuilder.Entity<Resource>().ToTable("Resource");
            modelBuilder.Entity<Time>().ToTable("Time");
        }


    }
}
