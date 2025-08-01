﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project4_Fall23;

#nullable disable

namespace Project4_Fall23.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231109164524_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("TableModels.Market", b =>
                {
                    b.Property<int>("MarketNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PocId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MarketNumber");

                    b.HasIndex("PocId");

                    b.ToTable("Market");
                });

            modelBuilder.Entity("TableModels.PointOfContact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MarketNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("StoreNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PointOfContact");
                });

            modelBuilder.Entity("TableModels.Store", b =>
                {
                    b.Property<int>("StoreNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("MarketNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PocId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PostalCode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StreedAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StoreNumber");

                    b.HasIndex("MarketNumber");

                    b.HasIndex("PocId");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("TableModels.Market", b =>
                {
                    b.HasOne("TableModels.PointOfContact", "Poc")
                        .WithMany()
                        .HasForeignKey("PocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Poc");
                });

            modelBuilder.Entity("TableModels.Store", b =>
                {
                    b.HasOne("TableModels.Market", null)
                        .WithMany("Stores")
                        .HasForeignKey("MarketNumber");

                    b.HasOne("TableModels.PointOfContact", "Poc")
                        .WithMany()
                        .HasForeignKey("PocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Poc");
                });

            modelBuilder.Entity("TableModels.Market", b =>
                {
                    b.Navigation("Stores");
                });
#pragma warning restore 612, 618
        }
    }
}
