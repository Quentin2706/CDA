using System;
using System.Collections.Generic;

#nullable disable

namespace VillageGreen.Data.Models
{
    public partial class Etatscommande
    {
        public Etatscommande()
        {
            Progressionscommandes = new HashSet<Progressionscommande>();
        }

        public int IdEtatCommande { get; set; }
        public string LibelleEtatCommande { get; set; }

        public virtual ICollection<Progressionscommande> Progressionscommandes { get; set; }
    }
}
