//-----------------------------------------------
// Proyect: EFChallenge 
// Developers: Christian Alvarado 
// Company:  Unosquare 2022
//-----------------------------------------------

using EFChallenge.Data.Models.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFChallenge.Data.Configuration
{
    /// <summary>
    /// Class CountyConfiguration
    /// Implements <IEntityTypeConfiguration<County>
    /// </summary>
    public class CountyConfiguration : IEntityTypeConfiguration<County>
    {
        /// <summary>
        /// Method that sets the properties of the class
        /// </summary>
        /// <param name="builder"> of type EntityTypeBuilder</param>
        public void Configure(EntityTypeBuilder<County> builder)
        {
            builder.ToTable("County");
            builder.HasKey(x => x.Id);
            builder.HasOne(z => z.State).WithMany(z => z.Counties).HasForeignKey(z => z.StateId);
            builder.HasData(
                new County { Id = 1, StateId = 1, Name = "Washington" },
                new County { Id = 2, StateId = 2, Name = "Guadalajara" });
        }
    }
}
