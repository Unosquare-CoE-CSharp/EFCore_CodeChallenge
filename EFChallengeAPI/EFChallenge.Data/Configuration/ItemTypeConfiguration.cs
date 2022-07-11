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
    /// Class ItemTypeConfiguration
    /// Implements IEntityTypeConfiguration<ItemType>
    /// </summary>
    public class ItemTypeConfiguration : IEntityTypeConfiguration<ItemType>
    {
        /// <summary>
        /// Method that sets the properties of the class
        /// </summary>
        /// <param name="builder"> of type EntityTypeBuilder</param>
        public void Configure(EntityTypeBuilder<ItemType> builder)
        {
            builder.ToTable("ItemType");
            builder.HasKey(x => x.Id);
            builder.HasData(
                new ItemType { Id = 1, Name = "Coke" },
                new ItemType { Id = 2, Name = "24 Cokes Package" },
                new ItemType { Id = 3, Name = "Box with 4 Cokes Package" });
        }
    }
}
