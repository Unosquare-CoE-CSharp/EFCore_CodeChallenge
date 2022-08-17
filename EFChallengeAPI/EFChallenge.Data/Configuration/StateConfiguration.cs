﻿//-----------------------------------------------
// Proyect: EFChallenge 
// Developers: Christian Alvarado 
// Company:  Unosquare 
//-----------------------------------------------

using EFChallenge.Data.Models.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFChallenge.Data.Configuration
{
    /// <summary>
    /// Class StateConfiguration
    /// Implements <IEntityTypeConfiguration<State>
    /// </summary>
    public class StateConfiguration : IEntityTypeConfiguration<State>
    {
        /// <summary>
        /// Method that sets the properties of the class
        /// </summary>
        /// <param name="builder"> of type EntityTypeBuilder</param>
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.ToTable("State");

            builder.HasKey(x => x.Id);
            builder.HasOne(z => z.Country).WithMany(z => z.States).HasForeignKey(z => z.CountryId);

            builder.HasData(Get());
        }

        /// <summary>
        /// Method seed data
        /// </summary>
        /// <returns>Data list</returns>
        private List<State> Get()
        {
            return new List<State>()
            {
                new State { Id = 1, CountryId = 1, Name = "Oregon" },
                new State { Id = 2, CountryId = 2, Name = "Jalisco" }
            };
        }
    }
 }

