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

            builder.HasData(Get());
        }

        /// <summary>
        /// Method seed data
        /// </summary>
        /// <returns>Data list</returns>
        public List<Item> Get()
        {
            var id = Guid.Parse("61b2f604-1e09-4b49-bafe-a7f0ee8dc0a5");
            return new List<Item>()
            {
                new Item { Id = id, ItemTypeId = 1, ItemStatusId = 1, ItemSubTypeId = 1, LocationId = 1, ParentItemId = id}
            };
        }
    }
}
