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
    /// Class ItemSubTypeConfiguration
    /// Implements <IEntityTypeConfiguration<Country>
    /// </summary>
    public class ItemSubTypeConfiguration : IEntityTypeConfiguration<ItemSubType>
    {
        /// <summary>
        /// Method that sets the properties of the class
        /// </summary>
        /// <param name="builder"> of type EntityTypeBuilder</param>
        public void Configure(EntityTypeBuilder<ItemSubType> builder)
        {
            builder.ToTable("ItemSubType");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(30).IsRequired();

            builder.HasData(Get());
        }

        /// <summary>
        /// Method seed data
        /// </summary>
        /// <returns>Data list</returns>
        private List<ItemSubType> Get() {
            return new List<ItemSubType>() {
                new ItemSubType {Id = 1, Name = "NameItemsubType"}
            };
        }
    }
}
