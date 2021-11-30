using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace APIGestionCommande.Data.Models
{
    public partial class Commande
    {
        public Commande()
        {
            Preparations = new HashSet<Preparation>();
        }

        [Key]
        public int IdCommande { get; set; }
        public DateTime DateCommande { get; set; }
        public int? NumeroCommande { get; set; }

        public virtual ICollection<Preparation> Preparations { get; set; }
    }
}
