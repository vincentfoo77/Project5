using Microsoft.EntityFrameworkCore;
using Project5.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project5.Server.Configurations.Entities
{
    public class CategorySeedConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
 new Category
 {
     CategoryId = 1,
     CategoryName="Studies",
 },
 new Category
 {
     CategoryId = 2,
     CategoryName = "Entertainment",
 }
);

           
        }
    }
}
