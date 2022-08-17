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
    /// Class ItemAddendumConfiguration
    /// Implements IEntityTypeConfiguration<ItemAddendum>
    /// </summary>
    public class ItemAddendumConfiguration : IEntityTypeConfiguration<ItemAddendum>
    {
        /// <summary>
        /// Method that sets the properties of the class
        /// </summary>
        /// <param name="builder"> of type EntityTypeBuilder</param>
        public void Configure(EntityTypeBuilder<ItemAddendum> builder)
        {
            builder.ToTable("ItemAddendum");

            builder.HasKey(x => x.Id);

            builder.HasData(Get());
        }

        /// <summary>
        /// Method seed data
        /// </summary>
        /// <returns>Data list</returns>
        private List<ItemAddendum> Get()
        {
            var addendumId = Guid.Parse("02a76c70-dafe-4550-afb1-01e610f72ce1");
            var itemId = Guid.Parse("61b2f604-1e09-4b49-bafe-a7f0ee8dc0a5");

            return new List<ItemAddendum>()
            {
                new ItemAddendum {Id = addendumId, ItemId = itemId, KeyField = "NameKeyField", Value = "Value001"}
            };
        }
    }
}
