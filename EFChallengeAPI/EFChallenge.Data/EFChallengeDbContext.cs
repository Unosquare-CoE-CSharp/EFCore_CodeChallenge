using EFChallenge.Data.Models.Company;
using EFChallenge.Data.Models.Item;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EFChallenge.Data
{
    public class EFChallengeDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; } = null!;
        public DbSet<Identifier> Identifiers { get; set; } = null!;
        public DbSet<IdentifierType> IdentifierTypes { get; set; } = null!;
        public DbSet<ItemAddendum> ItemAddenda { get; set; } = null!;
        public DbSet<ItemContainerConstraint> ItemContainerConstraints { get; set; } = null!;
        public DbSet<ItemIdentifier> ItemIdentifiers { get; set; } = null!;
        public DbSet<ItemStatus> ItemStatuses { get; set; } = null!;
        public DbSet<ItemSubType> ItemSubTypes { get; set; } = null!;
        public DbSet<ItemType> ItemTypes { get; set; } = null!;

        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<AddressType> AddressTypes { get; set; } = null!;
        public DbSet<Company> Companies { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<County> Counties { get; set; } = null!;
        public DbSet<State> States { get; set; } = null!;
        public EFChallengeDbContext(DbContextOptions<EFChallengeDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply automatic configurations for 'known' kinds of properties
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var entityProperty in entityType.GetProperties())
                {
                    if (entityProperty.ClrType == typeof(string) && entityProperty.Name.Equals("Name"))
                    {
                        entityProperty.SetMaxLength(150);
                    }

                    if (entityProperty.ClrType == typeof(string) && entityProperty.Name.EndsWith("Url"))
                    {
                        entityProperty.SetIsUnicode(false);
                    }
                }
            }

            // Apply specific configurations
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

//To Add Migrations:
//Add-Migration -Name InitialMigration -Context EFChallengeDbContext -StartupProject EFChallenge.API -Project EFChallenge.Data
