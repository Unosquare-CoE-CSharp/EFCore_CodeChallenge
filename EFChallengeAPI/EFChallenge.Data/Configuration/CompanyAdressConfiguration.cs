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
    /// Class CompanyAdressConfiguration
    /// Implements <IEntityTypeConfiguration<CompanyAddress>
    /// </summary>
    public class CompanyAdressConfiguration : IEntityTypeConfiguration<CompanyAddress>
    {
        /// <summary>
        /// Method that sets the properties of the class
        /// </summary>
        /// <param name="builder"> of type EntityTypeBuilder</param>
        public void Configure(EntityTypeBuilder<CompanyAddress> builder)
        {
            builder.ToTable("CompanyAddress");
            builder.HasKey(x => x.Id);

            //entityTypeBuilder.HasOne(z => z.Address).WithMany(z => z.CompanyAddresses).HasForeignKey(z => z.AdressId);
            builder.HasOne(z => z.Address).WithOne(z => z.CompanyAddress).HasForeignKey<CompanyAddress>(z => z.AddressId);

            //entityTypeBuilder.HasOne(y => y.Company).WithMany(y => y.CompanyAddresses).HasForeignKey(y => y.CompanyId);
            builder.HasOne(y => y.Company).WithOne(y => y.CompanyAddress).HasForeignKey<CompanyAddress>(z => z.CompanyId);

            builder.HasData(
                new CompanyAddress { Id = 1, CompanyId = 1, AddressId = 1 },
                new CompanyAddress { Id = 2, CompanyId = 1, AddressId = 2 });
        }
    }
}
