using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace APIVilles.Data.Models
{
    public partial class Departement
    {
        [Key]
        public int IdDepartement { get; set; }
        public string Nom { get; set; }

        public List<Ville> LesVilles { get; set; }
    }
}
