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
    }
}
