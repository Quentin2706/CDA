using System;
using System.Collections.Generic;

#nullable disable

namespace ApiVillesDept.Data.Models
{
    public partial class Departement
    {
        public Departement()
        {
            Villes = new HashSet<Ville>();
        }

        public int IdDepartement { get; set; }
        public string Nom { get; set; }

        public virtual ICollection<Ville> Villes { get; set; }
    }
}
