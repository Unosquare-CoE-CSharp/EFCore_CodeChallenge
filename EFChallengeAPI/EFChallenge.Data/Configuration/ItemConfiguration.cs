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
    /// Implements IEntityTypeConfiguration<Item>
    /// </summary>
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        /// <summary>
        /// Method that sets the properties of the class
        /// </summary>
        /// <param name="builder"> of type EntityTypeBuilder</param>
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Item");
            builder.HasKey(x => x.Id);
            builder.HasOne(z => z.ParentItem).WithMany().HasForeignKey(z => z.ParentItemId);
        }
    }
}
