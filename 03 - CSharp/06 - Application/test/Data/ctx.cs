using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using test.Data.Models;

#nullable disable

namespace test.Data
{
    public partial class ctx : DbContext
    {
        public ctx()
        {
        }

        public ctx(DbContextOptions<ctx> options)
            : base(options)
        {
        }

        public virtual DbSet<Voiture> Voitures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost;user=root;database=gestionvoitures;ssl mode=none");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Voiture>(entity =>
            {
                entity.HasKey(e => e.IdVoiture)
                    .HasName("PRIMARY");

                entity.ToTable("voitures");

                entity.Property(e => e.IdVoiture)
                    .HasColumnType("int(11)")
                    .HasColumnName("idVoiture");

                entity.Property(e => e.Km)
                    .HasColumnType("int(11)")
                    .HasColumnName("km");

                entity.Property(e => e.Marque)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("marque");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
