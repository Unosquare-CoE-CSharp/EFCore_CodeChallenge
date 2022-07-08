using EFChallenge.Data.Models.Item;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFChallenge.Data.Configurations
{
    internal class IdentifierTypeConfig : IEntityTypeConfiguration<IdentifierType>
    {
        public void Configure(EntityTypeBuilder<IdentifierType> entity)
        {
            entity.HasIndex(c => c.Name).IsUnique();
            entity.HasData(new IdentifierType
            {
                Id = 1,
                Name = "Barcode"
            });
            entity.HasData(new IdentifierType
            {
                Id = 2,
                Name = "QR Code"
            });
            entity.HasData(new IdentifierType
            {
                Id = 3,
                Name = "RFID Chip"
            });
        }
    }

    internal class ItemSubTypeConfig : IEntityTypeConfiguration<ItemSubType>
    {
        public void Configure(EntityTypeBuilder<ItemSubType> entity)
        {
            entity.HasIndex(c => c.Name).IsUnique();
            entity.HasData(new ItemSubType
            {
                Id = 1,
                Name = "Can"
            });
            entity.HasData(new ItemSubType
            {
                Id = 2,
                Name = "Plastic"
            });
        }
    }
}
