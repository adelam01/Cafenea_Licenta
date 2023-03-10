// <auto-generated />
using Cafenea.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cafenea.Migrations
{
    [DbContext(typeof(CafeneaContext))]
    [Migration("20230309174311_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Cafenea.Models.Cafea", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Aroma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DenumireCafea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lapte")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PretFinal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TipCafea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Topping")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Cafea");
                });
#pragma warning restore 612, 618
        }
    }
}
