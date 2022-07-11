using EFChallenge.Data.Models.Item;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFChallenge.Data.Configuration
{
    public class IdentifierConfiguration
    {
        public IdentifierConfiguration(EntityTypeBuilder<Identifier> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.HasOne(z => z.IdentifierType).WithMany(z => z.Identifiers).HasForeignKey(z => z.IdentifierTypeId);
        }
    }
}
