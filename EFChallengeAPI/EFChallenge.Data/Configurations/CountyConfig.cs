using EFChallenge.Data.Models.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFChallenge.Data.Configurations
{
    internal class CountyConfig : IEntityTypeConfiguration<County>
    {
        public void Configure(EntityTypeBuilder<County> entity)
        {            
            entity.HasData(new County
            {
                Id = 1,
                StateId = 1,
                Name = "Washington"
            });
            entity.HasData(new County
            {
                Id = 2,
                StateId = 2,
                Name = "Guadalajara"
            });
        }
    }
}
