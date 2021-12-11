using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageGreen.Data.Dtos
{
    public class ProgressionCommandeDTOIn
    {
        public int IdCommande { get; set; }
        public int IdEtatCommande { get; set; }
        public DateTime DateEtatCommande { get; set; }
    }

    public class ProgressionCommandeDTOOut
    {
        public int IdProgressionCommande { get; set; }
        public int IdCommande { get; set; }
        public string NumeroCommande { get; set; }
        public int IdEtatCommande { get; set; }
        public string LibelleEtatCommande { get; set; }
        public DateTime DateEtatCommande { get; set; }
    }
}
