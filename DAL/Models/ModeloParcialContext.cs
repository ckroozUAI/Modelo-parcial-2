using System;
using System.Collections.Generic;
using ENTITIES.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class ModeloParcialContext : DbContext
{
    public ModeloParcialContext()
    {
    }

    public ModeloParcialContext(DbContextOptions<ModeloParcialContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aplicacion> Aplicacion { get; set; }

    public virtual DbSet<Categoria> Categoria { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(ConeccionString.getConectionString());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aplicacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Aplicaci__3214EC27D67745FC");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Desarrolladora)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Titulo)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Aplicacion)
                .HasForeignKey(d => d.IdCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Aplicacion_Categoria");
        });

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3214EC27CE8EDCED");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PorcentajeDescuento).HasColumnType("decimal(5, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
