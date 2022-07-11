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
    /// Implements <IEntityTypeConfiguration<Address>
    /// </summary>
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        /// <summary>
        /// Method that sets the properties of the class
        /// </summary>
        /// <param name="builder"> of type EntityTypeBuilder</param>
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address");

            builder.HasKey(x => x.Id);
            builder.Property(a => a.Line1).HasMaxLength(250);
            builder.Property(b => b.Line2).HasMaxLength(250);
            builder.Property(c => c.City).HasMaxLength(150);
            builder.Property(d => d.ZipPostalCode).HasMaxLength(15);
            builder.HasOne(z => z.County).WithMany(z => z.Addresses).HasForeignKey(z => z.CountyId);
            builder.HasOne(y => y.AddressType).WithMany(y => y.Addresses).HasForeignKey(y => y.AddressTypeId);

            builder.HasData(
                new Address { Id = 1, AddressTypeId = 2, Line1 = "4800 Meadows Road, Suite 300 Lake Oswego", ZipPostalCode = "97035", City = "Portland", CountyId = 1 },
                new Address { Id = 2, AddressTypeId = 1, Line1 = "Av. de las Américas 1536, Country Club", ZipPostalCode = "44637", City = "Guadalajara", CountyId = 2 });

        }
    }
}
