//-----------------------------------------------
// Proyect: EFChallenge                         
// Developers: Christian Alvarado               
// Company:  Unosquare 2022                     
//-----------------------------------------------

using EFChallenge.Data.Models.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFChallenge.Data.Configuration
{
    /// <summary>
    /// Class AddressConfiguration
    /// Implements <IEntityTypeConfiguration<AddressType>
    /// </summary>
    public class AddressTypeConfiguration : IEntityTypeConfiguration<AddressType>
    {
        /// <summary>
        /// Method that sets the properties of the class
        /// </summary>
        /// <param name="builder"> of type EntityTypeBuilder</param>
        public void Configure(EntityTypeBuilder<AddressType> builder)
        {
            builder.ToTable("AddreessType");

            builder.HasKey(x => x.Id);

            builder.HasData(
                new AddressType { Id = 1, Name = "Phsycal Address" },
                new AddressType { Id = 2, Name = "IRS Address" });
        }
    }
}
