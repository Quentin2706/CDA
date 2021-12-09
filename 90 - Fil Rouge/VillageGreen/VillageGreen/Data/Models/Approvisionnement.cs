using System;
using System.Collections.Generic;

#nullable disable

namespace VillageGreen.Data.Models
{
    public partial class Approvisionnement
    {
        public int IdApprovisionnement { get; set; }
        public int? IdProduit { get; set; }
        public int? IdFournisseur { get; set; }
        public string RefFournisseur { get; set; }

        public virtual Fournisseur IdFournisseurNavigation { get; set; }
        public virtual Produit IdProduitNavigation { get; set; }
    }
}
