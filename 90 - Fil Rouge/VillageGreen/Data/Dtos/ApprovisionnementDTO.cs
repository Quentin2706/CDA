using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageGreen.Data.Dtos
{
    public class ApprovisionnementDTOIn
    {
        public int IdProduit { get; set; }
        public int? IdFournisseur { get; set; }
        public string RefFournisseur { get; set; }
    }

    public class ApprovisionnementDTOOut
    {
        public int IdApprovisionnement { get; set; }
        public int IdProduit { get; set; }
        public string LibelleProduit { get; set; }
        public string RefProduit { get; set; }
        public int? IdFournisseur { get; set; }
        public string nomFournisseur { get; set; }
        public string RefFournisseur { get; set; }
    }
}
