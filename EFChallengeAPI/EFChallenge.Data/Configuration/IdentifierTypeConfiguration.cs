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
    /// Class IdentifierTypeConfiguration
    /// Implements <IEntityTypeConfiguration<Country>
    /// </summary>
    public class IdentifierTypeConfiguration : IEntityTypeConfiguration<IdentifierType>
    {
        /// <summary>
        /// Method that sets the properties of the class
        /// </summary>
        /// <param name="builder"> of type EntityTypeBuilder</param>
        public void Configure(EntityTypeBuilder<IdentifierType> builder)
        {
            builder.ToTable("IdentifierType");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(25).IsRequired();

            builder.HasData(Get());
        }

        /// <summary>
        /// Method seed data
        /// </summary>
        /// <returns>Data list</returns>
        private List<IdentifierType> Get()
        {
            return new List<IdentifierType>()
            {
                new IdentifierType {Id = 1, Name = "NombreIdentifierType"}
            };
        }
    }
}
