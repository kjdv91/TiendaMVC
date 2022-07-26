﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tienda.Data;

#nullable disable

namespace Tienda.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220725165521__Three")]
    partial class _Three
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Tienda.Models.Categoria", b =>
                {
                    b.Property<long>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdCategoria"), 1L, 1);

                    b.Property<string>("NombreCategoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroOrden")
                        .HasColumnType("int");

                    b.HasKey("IdCategoria");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Tienda.Models.TipoAplication", b =>
                {
                    b.Property<long>("IdTipoAplicacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdTipoAplicacion"), 1L, 1);

                    b.Property<string>("NombreAplicacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTipoAplicacion");

                    b.ToTable("TipoAplication");
                });
#pragma warning restore 612, 618
        }
    }
}
