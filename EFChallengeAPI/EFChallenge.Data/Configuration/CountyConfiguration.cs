using EFChallenge.Data.Models.Company;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFChallenge.Data.Configuration
{
    public  class CountyConfiguration
    {
        public CountyConfiguration(EntityTypeBuilder<County> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.HasOne(z => z.State).WithMany(z => z.Counties).HasForeignKey(z => z.StateId);
        }
    }
}
