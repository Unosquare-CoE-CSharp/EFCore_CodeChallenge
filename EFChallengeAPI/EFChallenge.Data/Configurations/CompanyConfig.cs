using EFChallenge.Data.Models.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFChallenge.Data.Configurations
{
    internal class CompanyConfig : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> entity)
        {
            entity.HasIndex(c => c.Name).IsUnique();
            entity.HasData(new Company
            {
                Id = 1,
                Name = "Unosquare"
            });
        }
    }
}
