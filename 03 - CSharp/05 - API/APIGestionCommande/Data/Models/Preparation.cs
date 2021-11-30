using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace APIGestionCommande.Data.Models
{
    public partial class Preparation
    {
        [Key]
        public int IdPreparation { get; set; }
        public int IdProduit { get; set; }
        public int IdCommande { get; set; }
        public DateTime DatePreparation { get; set; }

        public virtual Commande Commande { get; set; }
        public virtual Produit Produit { get; set; }
    }
}
