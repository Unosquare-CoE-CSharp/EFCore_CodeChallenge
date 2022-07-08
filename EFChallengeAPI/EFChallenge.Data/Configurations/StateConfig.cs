using EFChallenge.Data.Models.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFChallenge.Data.Configurations
{
    internal class StateConfig : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> entity)
        {
            entity.HasIndex(c => c.Name).IsUnique();
            entity.HasData(new State
            {
                Id = 1,
                CountryId= 1,
                Name = "Oregon"
            });
            entity.HasData(new State
            {
                Id = 2,
                CountryId = 2,
                Name = "Jalisco"
            });
        }
    }
}
