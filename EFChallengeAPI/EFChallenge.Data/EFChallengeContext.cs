using EFChallenge.Data.Configuration;
using EFChallenge.Data.Models.Company;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFChallenge.Data
{
    public class EFChallengeContext : DbContext
    {
        public EFChallengeContext() { }
        public EFChallengeContext(DbContextOptions<EFChallengeContext> options)
            : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; } 

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().ToTable("Country");

            new CountryConfiguration(modelBuilder.Entity<Country>());
            base.OnModelCreating(modelBuilder);

        }

    }
}
