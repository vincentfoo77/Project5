using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project5.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project5.Server.Configurations.Entities
{
    public class Event_DetailSeedConfiguration : IEntityTypeConfiguration<Event_Details>
    {
        public void Configure(EntityTypeBuilder<Event_Details> builder)
        {
            builder.HasData(
               new Event_Details
               {
                   Id = 1,
                   EventsId = 1,
                   Category="Studies",
                   Venue="Classroom",
               },
               new Event_Details
               {
                   Id = 2,
                   EventsId = 2,
                   Category = "Entertainment",
                   Venue = "Lab",
               }
        );
        }
    }
}
