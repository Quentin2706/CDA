using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageGreen.Data.Dtos
{
    public class RubriqueDTOIn
    {
        public string LibelleRubrique { get; set; }
        public int? IdRubriqueMere { get; set; }
    }

    public class RubriqueRubriqueMereDTOOut
    {
        public int IdRubrique { get; set; }
        public string LibelleRubrique { get; set; }
        public int? IdRubriqueMere { get; set; }
    }

    public class RubriqueDTOOut
    {
        public int IdRubrique { get; set; }
        public string LibelleRubrique { get; set; }
    }
}
