using EFChallenge.Data.Models.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFChallenge.Data.Configurations
{
    internal class CountryConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> entity)
        {
            entity.HasIndex(c => c.Name).IsUnique();
            entity.HasData(new Country
            {
                Id = 1,
                Name = "United States of America"
            });
            entity.HasData(new Country
            {
                Id = 2,                
                Name = "Mexico"
            });
        }
    }
}
