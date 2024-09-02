﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductoAPI.Models;

#nullable disable

namespace ProductoAPI.Migrations
{
    [DbContext(typeof(ProductoContext))]
    [Migration("20240902011442_Migracion Inicial Producto API")]
    partial class MigracionInicialProductoAPI
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductoAPI.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Categoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Categoria = "Electrónica",
                            Descripcion = "Una laptop de alto rendimiento.",
                            Nombre = "Laptop"
                        },
                        new
                        {
                            Id = 2,
                            Categoria = "Electrónica",
                            Descripcion = "Una smartphone de nueva generación.",
                            Nombre = "Smartphone"
                        },
                        new
                        {
                            Id = 3,
                            Categoria = "Muebles",
                            Descripcion = "Una silla de escritorio cómoda.",
                            Nombre = "Silla de Escritorio"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
