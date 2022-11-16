﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Web.Data;

#nullable disable

namespace Web.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Web.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnOrder(0);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Cost")
                        .HasColumnType("numeric");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Link")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnOrder(1);

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SaleOff")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("products");
                });

            modelBuilder.Entity("Web.Models.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnOrder(0);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Link")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnOrder(1);

                    b.HasKey("Id");

                    b.ToTable("product_category");
                });
#pragma warning restore 612, 618
        }
    }
}
