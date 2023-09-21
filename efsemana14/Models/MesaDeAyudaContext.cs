using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace efsemana14.Models;

public partial class MesaDeAyudaContext : DbContext
{
    public MesaDeAyudaContext()
    {
    }

    public MesaDeAyudaContext(DbContextOptions<MesaDeAyudaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Solicitud> Solicituds { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LEO;Initial Catalog=MesaDeAyuda;Integrated Security=SSPI; User ID=sa;Password=caPaCidadZ; Integrated security=True;Encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Numdoc).HasName("PK__Cliente__FBBB7C6F6C461AE8");

            entity.ToTable("Cliente");

            entity.Property(e => e.Numdoc)
                .ValueGeneratedNever()
                .HasColumnName("numdoc");
            entity.Property(e => e.ApeCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apeCliente");
            entity.Property(e => e.Clave)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DirCliente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("dirCliente");
            entity.Property(e => e.IdCliente)
                .ValueGeneratedOnAdd()
                .HasColumnName("idCliente");
            entity.Property(e => e.IdRol)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Id_rol");
            entity.Property(e => e.NomCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nomCliente");
            entity.Property(e => e.TelCliente).HasColumnName("telCliente");
            entity.Property(e => e.TipoDocCliente)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tipoDocCliente");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Solicitud>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Solicitud");

            entity.Property(e => e.ApeCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apeCliente");
            entity.Property(e => e.Detalle)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("detalle");
            entity.Property(e => e.DirCliente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("dirCliente");
            entity.Property(e => e.IdSoli)
                .ValueGeneratedOnAdd()
                .HasColumnName("idSoli");
            entity.Property(e => e.NomCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nomCliente");
            entity.Property(e => e.NomSoporte)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nomSoporte");
            entity.Property(e => e.NumDocSo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numDocSo");
            entity.Property(e => e.Numdoc).HasColumnName("numdoc");
            entity.Property(e => e.TelCliente).HasColumnName("telCliente");
            entity.Property(e => e.TipoDocCli)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tipoDocCli");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
