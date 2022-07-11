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
    /// Class ItemContainerConstraintConfig
    /// Implements IEntityTypeConfiguration<ItemContainerConstraint>
    /// </summary>
    public class ItemContainerConstraintConfig : IEntityTypeConfiguration<ItemContainerConstraint>    
    {
        /// <summary>
        /// Method that sets the properties of the class
        /// </summary>
        /// <param name="builder"> of type EntityTypeBuilder</param>
        public void Configure(EntityTypeBuilder<ItemContainerConstraint> builder)
        {
            builder.ToTable("ItemContainerConstraint");
            builder.HasKey(x => x.Id);
            builder.HasOne(z => z.ItemType).WithOne(y => y.ItemContainerConstraint).HasForeignKey<ItemContainerConstraint>(z => z.ItemTypeId);

            builder.HasData(
                new ItemContainerConstraint { Id = 1, ItemTypeId = 1, Min = 1, Max = 1 },
                new ItemContainerConstraint { Id = 2, ItemTypeId = 2, Min = 2, Max = 2 },
                new ItemContainerConstraint { Id = 3, ItemTypeId = 3, Min = 1, Max = 1 });

        }
    }
}
