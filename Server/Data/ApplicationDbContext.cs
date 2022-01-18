using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Project5.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project5.Shared.Domain;
using Project5.Server.Configurations.Entities;

namespace Project5.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Events> Event { get; set; }
        public DbSet<Event_Details> Event_details { get; set; }
        public DbSet<Attendees> Attendee { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Students> Student { get; set; }
        public DbSet<Teachers> Teacher { get; set; }
        public DbSet<Venue> venues { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new CategorySeedConfiguration());
            builder.ApplyConfiguration(new EventSeedConfiguration());
            builder.ApplyConfiguration(new Event_DetailSeedConfiguration());
        }
    }
}
