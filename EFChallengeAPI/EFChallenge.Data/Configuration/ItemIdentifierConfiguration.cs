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

            builder.HasData(Get());
        }

        /// <summary>
        /// Method seed data
        /// </summary>
        /// <returns>Data list</returns>
        private List<ItemIdentifier> Get()
        {
            var itemId = Guid.Parse("61b2f604-1e09-4b49-bafe-a7f0ee8dc0a5");
            
            var itemIdentifierId = Guid.Parse("1d847c14-4722-47c4-bacf-bf9d3523345f");

            return new List<ItemIdentifier>()
            {
                new ItemIdentifier {Id = 1, ItemId = itemId, ItemIdentifierId = itemIdentifierId }
            };
        }
    }
 }

