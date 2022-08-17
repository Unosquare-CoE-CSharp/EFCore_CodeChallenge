//-----------------------------------------------
// Proyect: EFChallenge 
// Developers: Christian Alvarado 
// Company:  Unosquare 2022
//-----------------------------------------------

using EFChallenge.Data.Models.Item;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFChallenge.Data.Configuration
{
    /// <summary>
    /// Class IdentifierConfiguration
    /// </summary>
    public class IdentifierConfiguration : IEntityTypeConfiguration<Identifier>
    {
        /// <summary>
        /// Configuration of identifier model
        /// </summary>
        /// <param name="entityTypeBuilder">EntityTypeBuilder</param>
        public void Configure(EntityTypeBuilder<Identifier> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("Identifier");

            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.HasOne(z => z.IdentifierType).WithMany(z => z.Identifiers).HasForeignKey(z => z.IdentifierTypeId);

            entityTypeBuilder.HasData(Get());
        }

        /// <summary>
        /// Method seed data
        /// </summary>
        /// <returns>Data list</returns>
        private List<Identifier> Get()
        {
            var id = Guid.Parse("1d847c14-4722-47c4-bacf-bf9d3523345f");

            return new List<Identifier>()
            {
                new Identifier {Id = id, Data = "Data test", IdentifierTypeId = 1}
            };
        }
    }
}
