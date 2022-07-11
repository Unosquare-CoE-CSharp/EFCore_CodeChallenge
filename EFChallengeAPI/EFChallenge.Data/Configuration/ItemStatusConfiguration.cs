//-----------------------------------------------
// Proyect: EFChallenge 
// Developers: Christian Alvarado 
// Company:  Unosquare 
//-----------------------------------------------

using EFChallenge.Data.Models.Item;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFChallenge.Data.Configuration
{
    /// <summary>
    /// Class ItemStatusConfiguration
    /// Implements IEntityTypeConfiguration<ItemStatus>
    /// </summary>
    public class ItemStatusConfiguration : IEntityTypeConfiguration<ItemStatus>
    {
        /// <summary>
        /// Method that sets the properties of the class
        /// </summary>
        /// <param name="builder"> of type EntityTypeBuilder</param>
        public void Configure(EntityTypeBuilder<ItemStatus> builder)
        {
            builder.ToTable("ItemStatus");

            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Name).IsUnique();

            builder.HasData(
                new ItemStatus { Id = 1, Name = "In Warehouse" },
                new ItemStatus { Id = 2, Name = "In Transit" },
                new ItemStatus { Id = 3, Name = "Delivered" });
        }
    }
}
