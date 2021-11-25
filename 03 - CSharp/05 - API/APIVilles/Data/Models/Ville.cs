using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace APIVilles.Data.Models
{
    public partial class Ville
    {
        [Key]
        public int IdVille { get; set; }
        public string Nom { get; set; }

        public int IdDepartement { get; set; }

        public Departement Departement { get; set; }
    }
}
