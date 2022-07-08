using EFChallenge.Data.Models.Item;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFChallenge.Data.Configurations
{
    internal class ItemTypeConfig : IEntityTypeConfiguration<ItemType>
    {
        public void Configure(EntityTypeBuilder<ItemType> entity)
        {
            entity.HasIndex(c => c.Name).IsUnique();
            entity.HasData(new ItemType
            {
                Id = 1,
                Name = "Coke"
            });
            entity.HasData(new ItemType
            {
                Id = 2,
                Name = "24 Cokes Package"
            });
            entity.HasData(new ItemType
            {
                Id =3,
                Name = "Box with 4 Cokes Package"
            });
        }
    }
}
