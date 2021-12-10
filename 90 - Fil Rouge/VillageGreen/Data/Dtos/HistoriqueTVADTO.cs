using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageGreen.Data.Dtos
{
    public class HistoriqueTVADTOIn
    {
        public int IdProduit { get; set; }
        public int IdTVA { get; set; }
        public DateTime DateTVA { get; set; }
    }

    public class HistoriqueTVADTOOut
    {
        public int IdHistoriqueTVA { get; set; }
        public int IdProduit { get; set; }
        public string LibelleProduit { get; set; }
        public string RefProduit { get; set; }
        public int IdRubrique { get; set; }
        public string LibelleRubrique { get; set; }
        public int IdTVA { get; set; }
        public int TauxTVA { get; set; }
        public DateTime DateTVA { get; set; }
    }

}
