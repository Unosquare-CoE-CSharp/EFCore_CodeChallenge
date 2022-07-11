﻿// <auto-generated />
using System;
using EFChallenge.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFChallenge.Data.Migrations
{
    [DbContext(typeof(EFChallengeContext))]
    [Migration("20220711001426_AddDataCountryWithAssembly")]
    partial class AddDataCountryWithAssembly
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFChallenge.Data.Models.Company.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AddressTypeId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("CountyId")
                        .HasColumnType("int");

                    b.Property<string>("Line1")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Line2")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ZipPostalCode")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("AddressTypeId");

                    b.HasIndex("CountyId");

                    b.ToTable("Address", (string)null);
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Company.AddressType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AddreessType", (string)null);
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Company.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Company", (string)null);
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Company.CompanyAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("CompanyId")
                        .IsUnique();

                    b.ToTable("CompanyAddress", (string)null);
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Company.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Country", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "USA"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mexico"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Argentina"
                        });
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Company.County", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("County", (string)null);
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Company.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("State", (string)null);
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.Identifier", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdentifierTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdentifierTypeId");

                    b.ToTable("Identifiers");
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.IdentifierType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IdentifierType", (string)null);
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ItemStatusId")
                        .HasColumnType("int");

                    b.Property<int>("ItemSubTypeId")
                        .HasColumnType("int");

                    b.Property<int>("ItemTypeId")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<Guid?>("ParentItemId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ItemStatusId");

                    b.HasIndex("ItemSubTypeId");

                    b.HasIndex("ItemTypeId");

                    b.HasIndex("ParentItemId");

                    b.ToTable("Item", (string)null);
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.ItemAddendum", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("KeyField")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ItemAddendum", (string)null);
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.ItemContainerConstraint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ItemTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Max")
                        .HasColumnType("int");

                    b.Property<int>("Min")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemTypeId")
                        .IsUnique();

                    b.ToTable("ItemContainerConstraint", (string)null);
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.ItemIdentifier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid>("ItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ItemIdentifierId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ItemId")
                        .IsUnique();

                    b.HasIndex("ItemIdentifierId")
                        .IsUnique();

                    b.ToTable("ItemIdentifier", (string)null);
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.ItemStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("ItemStatus", (string)null);
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.ItemSubType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ItemSubtype", (string)null);
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.ItemType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ItemType", (string)null);
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Company.Address", b =>
                {
                    b.HasOne("EFChallenge.Data.Models.Company.AddressType", "AddressType")
                        .WithMany("Addresses")
                        .HasForeignKey("AddressTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFChallenge.Data.Models.Company.County", "County")
                        .WithMany("Addresses")
                        .HasForeignKey("CountyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddressType");

                    b.Navigation("County");
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Company.CompanyAddress", b =>
                {
                    b.HasOne("EFChallenge.Data.Models.Company.Address", "Address")
                        .WithOne("CompanyAddress")
                        .HasForeignKey("EFChallenge.Data.Models.Company.CompanyAddress", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFChallenge.Data.Models.Company.Company", "Company")
                        .WithOne("CompanyAddress")
                        .HasForeignKey("EFChallenge.Data.Models.Company.CompanyAddress", "CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Company.County", b =>
                {
                    b.HasOne("EFChallenge.Data.Models.Company.State", "State")
                        .WithMany("Counties")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Company.State", b =>
                {
                    b.HasOne("EFChallenge.Data.Models.Company.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.Identifier", b =>
                {
                    b.HasOne("EFChallenge.Data.Models.Item.IdentifierType", "IdentifierType")
                        .WithMany("Identifiers")
                        .HasForeignKey("IdentifierTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdentifierType");
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.Item", b =>
                {
                    b.HasOne("EFChallenge.Data.Models.Item.ItemStatus", "ItemStatus")
                        .WithMany()
                        .HasForeignKey("ItemStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFChallenge.Data.Models.Item.ItemSubType", "ItemSubType")
                        .WithMany()
                        .HasForeignKey("ItemSubTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFChallenge.Data.Models.Item.ItemType", "ItemType")
                        .WithMany()
                        .HasForeignKey("ItemTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFChallenge.Data.Models.Item.Item", "ParentItem")
                        .WithMany()
                        .HasForeignKey("ParentItemId");

                    b.Navigation("ItemStatus");

                    b.Navigation("ItemSubType");

                    b.Navigation("ItemType");

                    b.Navigation("ParentItem");
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.ItemContainerConstraint", b =>
                {
                    b.HasOne("EFChallenge.Data.Models.Item.ItemType", "ItemType")
                        .WithOne("ItemContainerConstraint")
                        .HasForeignKey("EFChallenge.Data.Models.Item.ItemContainerConstraint", "ItemTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ItemType");
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.ItemIdentifier", b =>
                {
                    b.HasOne("EFChallenge.Data.Models.Item.Item", "item")
                        .WithOne("ItemIdentifier")
                        .HasForeignKey("EFChallenge.Data.Models.Item.ItemIdentifier", "ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFChallenge.Data.Models.Item.Identifier", "identifier")
                        .WithOne("ItemIdentifier")
                        .HasForeignKey("EFChallenge.Data.Models.Item.ItemIdentifier", "ItemIdentifierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("identifier");

                    b.Navigation("item");
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Company.Address", b =>
                {
                    b.Navigation("CompanyAddress")
                        .IsRequired();
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Company.AddressType", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Company.Company", b =>
                {
                    b.Navigation("CompanyAddress")
                        .IsRequired();
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Company.Country", b =>
                {
                    b.Navigation("States");
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Company.County", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Company.State", b =>
                {
                    b.Navigation("Counties");
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.Identifier", b =>
                {
                    b.Navigation("ItemIdentifier")
                        .IsRequired();
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.IdentifierType", b =>
                {
                    b.Navigation("Identifiers");
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.Item", b =>
                {
                    b.Navigation("ItemIdentifier");
                });

            modelBuilder.Entity("EFChallenge.Data.Models.Item.ItemType", b =>
                {
                    b.Navigation("ItemContainerConstraint")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
