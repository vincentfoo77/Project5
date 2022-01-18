using Microsoft.EntityFrameworkCore;
using Project5.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project5.Server.Configurations.Entities
{
    public class EventSeedConfiguration : IEntityTypeConfiguration<Events>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Events> builder)
        {
            builder.HasData(
                new Events {
                            Id = 1,
                            EventName = "Study Program",
                            Participants=20,
                },
                new Events{
                            Id = 2,
                            EventName = "Gaming Competition",
                            Participants=15
                }
         );

          
        }
    }
}
