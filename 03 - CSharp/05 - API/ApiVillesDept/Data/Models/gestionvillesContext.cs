using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ApiVillesDept.Data.Models
{
    public partial class gestionvillesContext : DbContext
    {
        public gestionvillesContext()
        {
        }

        public gestionvillesContext(DbContextOptions<gestionvillesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Departement> Departements { get; set; }
        public virtual DbSet<Ville> Villes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Name=def");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departement>(entity =>
            {
                entity.HasKey(e => e.IdDepartement)
                    .HasName("PRIMARY");

                entity.ToTable("departements");

                entity.Property(e => e.IdDepartement)
                    .HasColumnType("int(11)")
                    .HasColumnName("idDepartement");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nom");
            });

            modelBuilder.Entity<Ville>(entity =>
            {
                entity.HasKey(e => e.IdVille)
                    .HasName("PRIMARY");

                entity.ToTable("villes");

                entity.HasIndex(e => e.IdDepartement, "Fk_villes_departements");

                entity.Property(e => e.IdVille)
                    .HasColumnType("int(11)")
                    .HasColumnName("idVille");

                entity.Property(e => e.IdDepartement)
                    .HasColumnType("int(11)")
                    .HasColumnName("idDepartement");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nom");

                entity.HasOne(d => d.IdDepartementNavigation)
                    .WithMany(p => p.Villes)
                    .HasForeignKey(d => d.IdDepartement)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_villes_departements");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
