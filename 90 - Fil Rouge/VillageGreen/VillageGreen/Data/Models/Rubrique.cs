using System;
using System.Collections.Generic;

#nullable disable

namespace VillageGreen.Data.Models
{
    public partial class Rubrique
    {
        public Rubrique()
        {
            InverseIdRubriqueMereNavigation = new HashSet<Rubrique>();
            Produits = new HashSet<Produit>();
        }

        public int IdRubrique { get; set; }
        public string LibelleRubrique { get; set; }
        public int? IdRubriqueMere { get; set; }

        public virtual Rubrique IdRubriqueMereNavigation { get; set; }
        public virtual ICollection<Rubrique> InverseIdRubriqueMereNavigation { get; set; }
        public virtual ICollection<Produit> Produits { get; set; }
    }
}
