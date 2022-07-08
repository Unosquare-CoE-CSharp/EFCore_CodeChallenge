using EFChallenge.Data.Models.Item;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFChallenge.Data.Configurations
{
    internal class ItemContainerConstraintConfig : IEntityTypeConfiguration<ItemContainerConstraint>
    {
        public void Configure(EntityTypeBuilder<ItemContainerConstraint> entity)
        {
            entity.HasData(new ItemContainerConstraint
            {
                Id = 1,
                ItemTypeId = 1,
                Min = 1,
                Max = 1
            });
            entity.HasData(new ItemContainerConstraint
            {
                Id = 2,
                ItemTypeId = 2,
                Min = 1,
                Max = 24
            });
            entity.HasData(new ItemContainerConstraint
            {
                Id = 3,
                ItemTypeId = 3,
                Min = 1,
                Max = 4
            });
        }
    }
}
