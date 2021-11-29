using APIVilles.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVilles.Data
{
    //public DbSet<Ville> Villes { get; set; }
    //public DbSet<Departement> Departements { get; set; }
    public class MyDbContext : DbContext
    {
       public DbSet<Ville> Villes { get; set; }
       public DbSet<Departement> Departements { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Ville>(e1 =>
            //{
            //    e1.ToTable("villes");
            //    //e1.Property(e => e.IdDepartement).HasColumnName("idDepartement");
            //    e1.HasOne<Departement>(e => e.Dept).WithOne().HasForeignKey<Departement>(e => e.IdDepartement);
            //});

            modelBuilder.Entity<Ville>()
           .HasOne<Departement>(s => s.Dept)
           .WithMany(d => d.LesVilles)
           .HasForeignKey(s => s.IdDepartement);

        }
    }
}
