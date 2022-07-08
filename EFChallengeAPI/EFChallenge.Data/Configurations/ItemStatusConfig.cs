using EFChallenge.Data.Models.Item;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFChallenge.Data.Configurations
{
    internal class ItemStatusConfig : IEntityTypeConfiguration<ItemStatus>
    {
        public void Configure(EntityTypeBuilder<ItemStatus> entity)
        {
            entity.HasIndex(c => c.Name).IsUnique();
            entity.HasData(new ItemStatus
            {
                Id = 1,
                Name = "In Warehouse"
            });
            entity.HasData(new ItemStatus
            {
                Id = 2,
                Name = "In Transit"
            });
            entity.HasData(new ItemStatus
            {
                Id = 3,
                Name = "Delivered"
            });
        }
    }
}
