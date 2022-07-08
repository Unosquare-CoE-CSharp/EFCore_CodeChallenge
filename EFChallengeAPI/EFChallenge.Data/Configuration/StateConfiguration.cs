using EFChallenge.Data.Models.Company;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFChallenge.Data.Configuration
{
    public class StateConfiguration
    {
        public StateConfiguration(EntityTypeBuilder<State> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.HasOne(z => z.Country).WithMany(z => z.States).HasForeignKey(z => z.CountryId);
        }
    }
    }

