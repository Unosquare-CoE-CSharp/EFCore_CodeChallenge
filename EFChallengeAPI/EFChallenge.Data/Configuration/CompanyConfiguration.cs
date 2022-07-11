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
    /// Class CompanyConfiguration
    /// Implements <IEntityTypeConfiguration<Company>
    /// </summary>
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        /// <summary>
        /// Method that sets the properties of the class
        /// </summary>
        /// <param name="builder"> of type EntityTypeBuilder</param>
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Company");
            builder.HasKey(x => x.Id);
            builder.HasData(
                new Company { Id = 1, Name = "Unosquare" });
        }
    }
}
