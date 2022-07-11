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
    /// Class ItemIdentifierConfiguration
    /// Implements IEntityTypeConfiguration<ItemIdentifier>
    /// </summary>
    public class ItemIdentifierConfiguration : IEntityTypeConfiguration<ItemIdentifier>
    {
        /// <summary>
        /// Method that sets the properties of the class
        /// </summary>
        /// <param name="builder"> of type EntityTypeBuilder</param>
        public void Configure(EntityTypeBuilder<ItemIdentifier> builder)
        {
            builder.ToTable("ItemIdentifier");
            builder.HasKey(x => x.Id);
            builder.HasOne(z => z.item).WithOne(z => z.ItemIdentifier).HasForeignKey<ItemIdentifier>(z => z.ItemId);
            builder.HasOne(y => y.identifier).WithOne(y => y.ItemIdentifier).HasForeignKey<ItemIdentifier>(y => y.ItemIdentifierId);
        }
    }
  }

