using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVillesDept.Data
{
    public class LeContext : DbContext
    {
        public DbSet<Ville> Villes { get; set; }
        public DbSet<Departement> Departements { get; set; }
        public LeContext(DbContextOptions<LeContext> options) : base(options)
        {

        }
    }
}
