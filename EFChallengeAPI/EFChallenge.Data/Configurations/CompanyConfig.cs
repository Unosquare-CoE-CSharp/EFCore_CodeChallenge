using EFChallenge.Data.Models.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFChallenge.Data.Configurations
{
    internal class CompanyConfig : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> entity)
        {
            //entity.Property(p => p.PublishedOn)
            //    .HasColumnType("date");
            //entity.HasIndex(x => x.PublishedOn);

            ////HasPrecision is a EF Core 5 method
            //entity.Property(p => p.Price).HasPrecision(9, 2);

            //entity.Property(x => x.ImageUrl).IsUnicode(false);

            //entity.HasQueryFilter(p => !p.SoftDeleted);

            ////----------------------------
            ////one-to-one with only one navigational property must be defined

            //entity.HasOne(p => p.Promotion)
            //    .WithOne()
            //    .HasForeignKey<PriceOffer>(p => p.BookId);
            entity.HasData(new Company
            {
                Name = "Unosquare"
            });
        }
    }
}
