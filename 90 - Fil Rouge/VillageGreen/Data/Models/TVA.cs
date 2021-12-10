using System;
using System.Collections.Generic;

#nullable disable

namespace VillageGreen.Data.Models
{
    public partial class TVA
    {
        public TVA()
        {
            HistoriqueTVA = new HashSet<HistoriqueTVA>();
        }

        public int IdTVA { get; set; }
        public int TauxTVA { get; set; }

        public virtual ICollection<HistoriqueTVA> HistoriqueTVA { get; set; }
    }
}
