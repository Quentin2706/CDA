using System;
using System.Collections.Generic;

#nullable disable

namespace VillageGreen.Data.Models
{
    public partial class Tva
    {
        public Tva()
        {
            Historiquetvas = new HashSet<Historiquetva>();
        }

        public int IdTva { get; set; }
        public int? TauxTva { get; set; }

        public virtual ICollection<Historiquetva> Historiquetvas { get; set; }
    }
}
