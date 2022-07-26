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
    [Migration("20220725221700_Add_Product")]
    partial class Add_Product
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroOrden")
                        .HasColumnType("int");

                    b.HasKey("IdCategoria");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Tienda.Models.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProducto"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("IdCategoria")
                        .HasColumnType("bigint");

                    b.Property<long>("IdTipoAplicacion")
                        .HasColumnType("bigint");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Precio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdProducto");

                    b.HasIndex("IdCategoria");

                    b.HasIndex("IdTipoAplicacion");

                    b.ToTable("Producto");
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

            modelBuilder.Entity("Tienda.Models.Producto", b =>
                {
                    b.HasOne("Tienda.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("IdCategoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tienda.Models.TipoAplication", "TipoAplication")
                        .WithMany()
                        .HasForeignKey("IdTipoAplicacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("TipoAplication");
                });
#pragma warning restore 612, 618
        }
    }
}
