//-----------------------------------------------
// Proyect: EFChallenge 
// Developers: Christian Alvarado 
// Company:  Unosquare 2022
//-----------------------------------------------

using EFChallenge.Data.Models.Company;
using EFChallenge.Data.Models.Item;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EFChallenge.Data
{
    /// <summary>
    /// Class EFChallengeContext 
    /// Class responsible for managing the database
    /// </summary>
    public class EFChallengeContext : DbContext
    {
        public EFChallengeContext() { }
        public EFChallengeContext(DbContextOptions<EFChallengeContext> options)
            : base(options) {}

        public DbSet<IdentifierType> IdentifierTypes { get; set; } = null!;
        public DbSet<Identifier> Identifiers { get; set; } = null!;
        public DbSet<ItemIdentifier> ItemIdentifiers { get; set; } = null!;
        public DbSet<ItemType> ItemTypes { get; set; } = null!;
        public DbSet<ItemContainerConstraint> ItemContainerConstraints { get; set; } = null!;
        public DbSet<Item> Items { get; set; } = null!;
        public DbSet<ItemStatus> ItemStatuses { get; set; } = null!;
        public DbSet<ItemAddendum> ItemAddendum { get; set; } = null!;
        public DbSet<ItemSubType> ItemSubTypes { get; set; } = null!;
        public DbSet<Company> Companies { get; set; } = null!;
        public DbSet<CompanyAddress> CompanyAddresses { get; set; } = null!;
        public DbSet<AddressType> AddressTypes { get; set; } = null!;
        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<County> Counties { get; set; } = null!;
        public DbSet<State> States { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
