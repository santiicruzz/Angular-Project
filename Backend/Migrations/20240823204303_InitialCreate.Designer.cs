﻿// <auto-generated />
using System;
using Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend.Migrations
{
    [DbContext(typeof(MotosContext))]
    [Migration("20240823204303_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Backend.Data.Moto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Cilindraje")
                        .HasColumnType("int")
                        .HasColumnName("cilindraje");

                    b.Property<string>("Linea")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("linea");

                    b.Property<string>("Marca")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("marca");

                    b.Property<int?>("Modelo")
                        .HasColumnType("int")
                        .HasColumnName("modelo");

                    b.Property<string>("Placa")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("placa");

                    b.Property<int?>("Precio")
                        .HasColumnType("int")
                        .HasColumnName("precio");

                    b.HasKey("Id")
                        .HasName("PK__motos__3213E83F21962CE0");

                    b.HasIndex(new[] { "Placa" }, "PlacaUnica")
                        .IsUnique()
                        .HasFilter("[placa] IS NOT NULL");

                    b.ToTable("motos", (string)null);
                });

            modelBuilder.Entity("Backend.Data.SP.SpVentasListar", b =>
                {
                    b.Property<int>("cilindraje")
                        .HasColumnType("int")
                        .HasColumnName("cilindraje");

                    b.Property<DateTime>("fechaVenta")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha");

                    b.Property<string>("marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("marca");

                    b.Property<string>("metodoPago")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nombre");

                    b.Property<int>("modelo")
                        .HasColumnType("int")
                        .HasColumnName("modelo");

                    b.Property<int>("precio")
                        .HasColumnType("int")
                        .HasColumnName("precio");

                    b.ToTable("spVentasListar");
                });

            modelBuilder.Entity("Backend.Data.TipoDocumento", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PK__tipoDocu__3213E83F205C5DE0");

                    b.ToTable("tipoDocumento", (string)null);
                });

            modelBuilder.Entity("Backend.Data.TipoPago", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PK__tipoPago__3213E83FCE9C1944");

                    b.ToTable("tipoPago", (string)null);
                });

            modelBuilder.Entity("Backend.Data.Venta", b =>
                {
                    b.Property<int>("IdVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idVenta");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVenta"));

                    b.Property<string>("ApellidoCliente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("apellidoCliente");

                    b.Property<string>("ApellidoVendedor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("apellidoVendedor");

                    b.Property<string>("CorreoCliente")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("correoCliente");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime")
                        .HasColumnName("fecha");

                    b.Property<int>("IdMoto")
                        .HasColumnType("int")
                        .HasColumnName("idMoto");

                    b.Property<int>("IdVendedor")
                        .HasColumnType("int")
                        .HasColumnName("idVendedor");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombreCliente");

                    b.Property<string>("NombreVendedor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombreVendedor");

                    b.Property<int>("NumeroDocumento")
                        .HasColumnType("int")
                        .HasColumnName("numeroDocumento");

                    b.Property<int>("Precio")
                        .HasColumnType("int")
                        .HasColumnName("precio");

                    b.Property<int>("TipoDocumento")
                        .HasColumnType("int")
                        .HasColumnName("tipoDocumento");

                    b.Property<int>("TipoPago")
                        .HasColumnType("int")
                        .HasColumnName("tipoPago");

                    b.HasKey("IdVenta")
                        .HasName("PK__ventas__077D561405C3179D");

                    b.HasIndex("IdMoto");

                    b.HasIndex(new[] { "CorreoCliente" }, "CorreoUnico")
                        .IsUnique();

                    b.HasIndex(new[] { "CorreoCliente" }, "UQ__ventas__F987A964FDF6F11A")
                        .IsUnique();

                    b.ToTable("ventas", (string)null);
                });

            modelBuilder.Entity("Backend.Data.Venta", b =>
                {
                    b.HasOne("Backend.Data.Moto", "IdMotoNavigation")
                        .WithMany("Venta")
                        .HasForeignKey("IdMoto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__ventas__idMoto__70DDC3D8");

                    b.Navigation("IdMotoNavigation");
                });

            modelBuilder.Entity("Backend.Data.Moto", b =>
                {
                    b.Navigation("Venta");
                });
#pragma warning restore 612, 618
        }
    }
}
