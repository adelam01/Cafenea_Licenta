﻿// <auto-generated />
using System;
using Cafenea.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cafenea.Migrations
{
    [DbContext(typeof(CafeneaContext))]
    partial class CafeneaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Cafenea.Models.Aroma", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("DenumireAroma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Pret")
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("ID");

                    b.ToTable("Aroma");
                });

            modelBuilder.Entity("Cafenea.Models.Cafea", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("AromaID")
                        .HasColumnType("int");

                    b.Property<string>("DenumireCafea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LapteID")
                        .HasColumnType("int");

                    b.Property<decimal>("PretFinal")
                        .HasColumnType("decimal(6,2)");

                    b.Property<int>("TipBoabeID")
                        .HasColumnType("int");

                    b.Property<int>("TipCafeaID")
                        .HasColumnType("int");

                    b.Property<int?>("ToppingID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AromaID");

                    b.HasIndex("LapteID");

                    b.HasIndex("TipBoabeID");

                    b.HasIndex("TipCafeaID");

                    b.HasIndex("ToppingID");

                    b.ToTable("Cafea");
                });

            modelBuilder.Entity("Cafenea.Models.Lapte", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("DenumireLapte")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Pret")
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("ID");

                    b.ToTable("Lapte");
                });

            modelBuilder.Entity("Cafenea.Models.TipBoabe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("DenumireBoabe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Pret")
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("ID");

                    b.ToTable("TipBoabe");
                });

            modelBuilder.Entity("Cafenea.Models.TipCafea", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<decimal>("Pret")
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("Tip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TipCafea");
                });

            modelBuilder.Entity("Cafenea.Models.Topping", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("DenumireTopping")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Pret")
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("ID");

                    b.ToTable("Topping");
                });

            modelBuilder.Entity("Cafenea.Models.Cafea", b =>
                {
                    b.HasOne("Cafenea.Models.Aroma", "Aroma")
                        .WithMany("Cafele")
                        .HasForeignKey("AromaID");

                    b.HasOne("Cafenea.Models.Lapte", "Lapte")
                        .WithMany("Cafele")
                        .HasForeignKey("LapteID");

                    b.HasOne("Cafenea.Models.TipBoabe", "TipBoabe")
                        .WithMany("Cafele")
                        .HasForeignKey("TipBoabeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cafenea.Models.TipCafea", "TipCafea")
                        .WithMany("Cafele")
                        .HasForeignKey("TipCafeaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cafenea.Models.Topping", "Topping")
                        .WithMany("Cafele")
                        .HasForeignKey("ToppingID");

                    b.Navigation("Aroma");

                    b.Navigation("Lapte");

                    b.Navigation("TipBoabe");

                    b.Navigation("TipCafea");

                    b.Navigation("Topping");
                });

            modelBuilder.Entity("Cafenea.Models.Aroma", b =>
                {
                    b.Navigation("Cafele");
                });

            modelBuilder.Entity("Cafenea.Models.Lapte", b =>
                {
                    b.Navigation("Cafele");
                });

            modelBuilder.Entity("Cafenea.Models.TipBoabe", b =>
                {
                    b.Navigation("Cafele");
                });

            modelBuilder.Entity("Cafenea.Models.TipCafea", b =>
                {
                    b.Navigation("Cafele");
                });

            modelBuilder.Entity("Cafenea.Models.Topping", b =>
                {
                    b.Navigation("Cafele");
                });
#pragma warning restore 612, 618
        }
    }
}
