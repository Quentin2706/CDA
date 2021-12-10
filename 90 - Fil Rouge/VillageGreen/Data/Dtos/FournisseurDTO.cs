using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageGreen.Data.Dtos
{
    public class FournisseurDTOIn
    {
        public string nomFournisseur { get; set; }
    }

    public class FournisseurDTOOut
    {
        public int IdFournisseur { get; set; }
        public string nomFournisseur { get; set; }
    }

}
