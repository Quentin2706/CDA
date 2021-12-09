using System;
using System.Collections.Generic;

#nullable disable

namespace VillageGreen.Data.Models
{
    public partial class Commande
    {
        public Commande()
        {
            Factures = new HashSet<Facture>();
            Lignescommandes = new HashSet<Lignescommande>();
            Livraisons = new HashSet<Livraison>();
            Progressionscommandes = new HashSet<Progressionscommande>();
        }

        public int IdCommande { get; set; }
        public string NumeroCommande { get; set; }
        public DateTime? DateCommande { get; set; }
        public int IdUser { get; set; }
        public int IdAdresse { get; set; }

        public virtual Adress IdAdresseNavigation { get; set; }
        public virtual Client IdUserNavigation { get; set; }
        public virtual ICollection<Facture> Factures { get; set; }
        public virtual ICollection<Lignescommande> Lignescommandes { get; set; }
        public virtual ICollection<Livraison> Livraisons { get; set; }
        public virtual ICollection<Progressionscommande> Progressionscommandes { get; set; }
    }
}
