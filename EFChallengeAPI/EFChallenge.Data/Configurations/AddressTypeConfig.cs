using EFChallenge.Data.Models.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFChallenge.Data.Configurations
{
    internal class AddressTypeConfig : IEntityTypeConfiguration<AddressType>
    {
        public void Configure(EntityTypeBuilder<AddressType> entity)
        {            
            entity.HasData(new AddressType
            {
                Name = "Physical Address"
            });
            entity.HasData(new AddressType
            {
                Name = "IRS Address"
            });
        }
    }
}
