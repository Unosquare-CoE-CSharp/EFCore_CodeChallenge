//-----------------------------------------------
// Proyect: EFChallenge 
// Developers: Christian Alvarado 
// Company:  Unosquare 
//-----------------------------------------------

using EFChallenge.Data.Models.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFChallenge.Data.Configuration
{
    /// <summary>
    /// Class CountryConfiguration
    /// Implements <IEntityTypeConfiguration<Country>
    /// </summary>
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        /// <summary>
        /// Method that sets the properties of the class
        /// </summary>
        /// <param name="builder"> of type EntityTypeBuilder</param>
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Country");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(25).IsRequired();
            
            builder.HasData(Get());
        }

        /// <summary>
        /// Method seed data
        /// </summary>
        /// <returns>Data list</returns>
        private List<Country> Get() {
            return new List<Country>() {
                new Country { Id = 1, Name = "USA" },
                new Country { Id = 2, Name = "Mexico" },
                new Country { Id = 3, Name = "Argentina" },
                new Country { Id = 4, Name = "Bolivia" }
            };
        }
    }
}
