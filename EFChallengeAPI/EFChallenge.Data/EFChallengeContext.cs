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
            //This ones are applied via Conventions
            modelBuilder.Entity<ItemAddendum>().ToTable("ItemAddendum");
            modelBuilder.Entity<ItemSubType>().ToTable("ItemSubtype");
            modelBuilder.Entity<IdentifierType>().ToTable("IdentifierType");

            //Seed(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }

        public static void Seed(ModelBuilder modelBuilder)
        {
            #region Country
            modelBuilder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "USA" },
                new Country { Id = 2, Name = "Mexico" });
            #endregion

            #region State
            modelBuilder.Entity<State>().HasData(
                new State { Id = 1, CountryId = 1, Name = "Oregon" },
                new State { Id = 2, CountryId = 2, Name = "Jalisco" });
            #endregion

            #region County
            modelBuilder.Entity<County>().HasData(
                new County { Id = 1, StateId = 1, Name = "Washington" },
                new County { Id = 2, StateId = 2, Name = "Guadalajara" });
            #endregion

            #region AddresType
            modelBuilder.Entity<AddressType>().HasData(
                new AddressType { Id = 1, Name = "Phsycal Address" },
                new AddressType { Id = 2, Name = "IRS Address" });
            #endregion

            #region Address
            modelBuilder.Entity<Address>().HasData(
                new Address { Id = 1, AddressTypeId = 2, Line1 = "4800 Meadows Road, Suite 300 Lake Oswego", ZipPostalCode = "97035", City = "Portland", CountyId = 1 },
                new Address { Id = 2, AddressTypeId = 1, Line1 = "Av. de las Américas 1536, Country Club",   ZipPostalCode = "44637", City = "Guadalajara", CountyId = 2 });
            #endregion

            #region CompanyAddres
            modelBuilder.Entity<CompanyAddress>().HasData(
                new CompanyAddress { Id = 1, CompanyId = 1, AddressId = 1 },
                new CompanyAddress { Id = 2, CompanyId = 1, AddressId = 2 });
            #endregion

            #region Company
            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Unosquare" });
            #endregion

            #region ItemType
            modelBuilder.Entity<ItemType>().HasData(
                new ItemType { Id = 1, Name = "Coke" },
                new ItemType { Id = 2, Name = "24 Cokes Package" },
                new ItemType { Id = 3, Name = "Box with 4 Cokes Package" });
            #endregion

            #region ItemContainer
            modelBuilder.Entity<ItemContainerConstraint>().HasData(
                new ItemContainerConstraint { Id = 1, ItemTypeId = 1, Min = 1, Max = 1 },
                new ItemContainerConstraint { Id = 2, ItemTypeId = 2, Min = 2, Max = 2 },
                new ItemContainerConstraint { Id = 3, ItemTypeId = 3, Min = 1, Max = 1 });
            #endregion

            #region ItemStatus
            modelBuilder.Entity<ItemStatus>().HasData(
                new ItemStatus { Id = 1, Name = "In Warehouse" },
                new ItemStatus { Id = 2, Name = "In Transit" },
                new ItemStatus { Id = 3, Name = "Delivered" });
            #endregion

        }

    }
}
