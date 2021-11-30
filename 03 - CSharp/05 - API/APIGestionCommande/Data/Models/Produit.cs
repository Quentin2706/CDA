using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace APIGestionCommande.Data.Models
{
    public partial class Produit
    {
        public Produit()
        {
            Preparations = new HashSet<Preparation>();
        }

        [Key]
        public int IdProduit { get; set; }
        public string LibelleProduit { get; set; }
        public decimal PrixProduit { get; set; }
        public int QuantiteProduit { get; set; }

        public virtual ICollection<Preparation> Preparations { get; set; }
    }
}
