using System;
using System.Collections.Generic;

#nullable disable

namespace VillageGreen.Data.Models
{
    public partial class HistoriqueTVA
    {
        public int IdHistoriqueTVA { get; set; }
        public int IdProduit { get; set; }
        public int IdTVA { get; set; }
        public DateTime DateTVA { get; set; }

        public virtual Produit Produit { get; set; }
        public virtual TVA TVA { get; set; }
    }
}
