using System;
using System.Collections.Generic;

#nullable disable

namespace VillageGreen.Data.Models
{
    public partial class Adress
    {
        public Adress()
        {
            Commandes = new HashSet<Commande>();
            Livraisons = new HashSet<Livraison>();
        }

        public int IdAdresse { get; set; }
        public string EmailAdresse { get; set; }
        public string TelMobile { get; set; }
        public string TelFixe { get; set; }
        public string Adresse { get; set; }
        public string Province { get; set; }
        public string ComplementAdresse { get; set; }
        public int IdVille { get; set; }

        public virtual Ville IdVilleNavigation { get; set; }
        public virtual ICollection<Commande> Commandes { get; set; }
        public virtual ICollection<Livraison> Livraisons { get; set; }
    }
}
