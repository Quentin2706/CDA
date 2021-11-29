using System;
using System.Collections.Generic;

#nullable disable

namespace ApiVillesDept.Data.Models
{
    public partial class Ville
    {
        public int IdVille { get; set; }
        public string Nom { get; set; }
        public int IdDepartement { get; set; }

        public virtual Departement IdDepartementNavigation { get; set; }
    }
}
