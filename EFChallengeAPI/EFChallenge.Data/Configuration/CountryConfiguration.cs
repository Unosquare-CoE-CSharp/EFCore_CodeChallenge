using EFChallenge.Data.Models.Company;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFChallenge.Data.Configuration
{
    public class CountryConfiguration
    {
        public CountryConfiguration(EntityTypeBuilder<Country> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Name).HasMaxLength(20).IsRequired();
        }
    }
}
