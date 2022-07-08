using EFChallenge.Data.Models.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFChallenge.Data.Configurations
{
    internal class AddressConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> entity)
        {            
            entity.HasData(new Address
            {
                Id = 1,
                AddressTypeId = 2,
                Line1 = "4800 Meadows Road, Suite 300 Lake Oswego",                
                ZipPostalCode= "97035",
                City = "Portland",
                CountyId = 1
            });
            entity.HasData(new Address
            {
                Id = 2,
                AddressTypeId=1,
                Line1 = "Av. de las Américas 1536, Country Club",
                ZipPostalCode = "44637",
                City = "Guadalajara",
                CountyId = 2
            });
        }
    }
}
