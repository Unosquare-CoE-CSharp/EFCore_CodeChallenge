using EFChallenge.Data.Configuration;
using EFChallenge.Data.Models.Company;
using EFChallenge.Data.Models.Item;
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

        ////public DbSet<Item> Items { get; set; } = null!;
        ////public DbSet<Identifier> Identifiers { get; set; } = null!;
        ////public DbSet<IdentifierType> IdentifierTypes { get; set; } = null!;
        ////public DbSet<ItemAddendum> ItemAddenda { get; set; } = null!;
        ////public DbSet<ItemContainerConstraint> ItemContainerConstraints { get; set; } = null!;
        ////public DbSet<ItemIdentifier> ItemIdentifiers { get; set; } = null!;
        ////public DbSet<ItemStatus> ItemStatuses { get; set; } = null!;
        ////public DbSet<ItemSubType> ItemSubTypes { get; set; } = null!;
        ////public DbSet<ItemType> ItemTypes { get; set; } = null!;

        ////public DbSet<Address> Addresses { get; set; } = null!;
        ////public DbSet<AddressType> AddressTypes { get; set; } = null!;
        ////public DbSet<Company> Companies { get; set; } = null!;
        
        public DbSet<County> Counties { get; set; } = null!;
        public DbSet<State> States { get; set; } = null!;

        public DbSet<Country> Countries { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().ToTable("Country");
            modelBuilder.Entity<State>().ToTable("State");
            modelBuilder.Entity<County>().ToTable("County");

            new CountryConfiguration(modelBuilder.Entity<Country>());
            new StateConfiguration(modelBuilder.Entity<State>());
            new CountyConfiguration(modelBuilder.Entity<County>());


            base.OnModelCreating(modelBuilder);

        }

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Name = "Francia"
                });

        }

    }
}
