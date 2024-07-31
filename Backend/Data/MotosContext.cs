using System;
using System.Collections.Generic;
using Backend.Data.SP;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data;

public partial class MotosContext : DbContext
{
    public MotosContext()
    {
    }

    public MotosContext(DbContextOptions<MotosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Moto> Motos { get; set; }

    public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }

    public virtual DbSet<TipoPago> TipoPagos { get; set; }

    public virtual DbSet<Venta> Ventas { get; set; }
    public virtual DbSet<SpVentasListar> spVentasListar { get; set; }
    public IEnumerable<SpVentasListar> SpVentaListar()
    {
        return spVentasListar.FromSqlInterpolated($"spGenerarListado").ToArray();
    }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Server=SANTIAGO\\SQLEXPRESS;Database=motos;Integrated Security=true; TrustServerCertificate=True;");
    //"Server=(localdb)\\mssqllocaldb;Database=BackendContext-54b220bb-2a94-4c0d-a48a-57ff339e7852;Trusted_Connection=True;MultipleActiveResultSets=true"

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Moto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__motos__3213E83F21962CE0");

            entity.ToTable("motos");

            entity.HasIndex(e => e.Placa, "PlacaUnica").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cilindraje).HasColumnName("cilindraje");
            entity.Property(e => e.Linea)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("linea");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("marca");
            entity.Property(e => e.Modelo).HasColumnName("modelo");
            entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("placa");
            entity.Property(e => e.Precio).HasColumnName("precio");
        });

        modelBuilder.Entity<TipoDocumento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tipoDocu__3213E83F205C5DE0");

            entity.ToTable("tipoDocumento");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<TipoPago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tipoPago__3213E83FCE9C1944");

            entity.ToTable("tipoPago");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Venta>(entity =>
        {
            entity.HasKey(e => e.IdVenta).HasName("PK__ventas__077D561405C3179D");

            entity.ToTable("ventas");

            entity.HasIndex(e => e.CorreoCliente, "CorreoUnico").IsUnique();

            entity.HasIndex(e => e.CorreoCliente, "UQ__ventas__F987A964FDF6F11A").IsUnique();

            entity.Property(e => e.IdVenta).HasColumnName("idVenta");
            entity.Property(e => e.ApellidoCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellidoCliente");
            entity.Property(e => e.ApellidoVendedor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellidoVendedor");
            entity.Property(e => e.CorreoCliente)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("correoCliente");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.IdMoto).HasColumnName("idMoto");
            entity.Property(e => e.IdVendedor).HasColumnName("idVendedor");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreCliente");
            entity.Property(e => e.NombreVendedor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreVendedor");
            entity.Property(e => e.NumeroDocumento).HasColumnName("numeroDocumento");
            entity.Property(e => e.Precio).HasColumnName("precio");
            entity.Property(e => e.TipoDocumento).HasColumnName("tipoDocumento");
            entity.Property(e => e.TipoPago).HasColumnName("tipoPago");

            entity.HasOne(d => d.IdMotoNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdMoto)
                .HasConstraintName("FK__ventas__idMoto__70DDC3D8");
        });

        modelBuilder.Entity<SpVentasListar>().HasNoKey();
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
