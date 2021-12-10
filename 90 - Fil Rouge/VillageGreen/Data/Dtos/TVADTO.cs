using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageGreen.Data.Dtos
{
    public class TVADTOIn
    {
        public int TauxTVA { get; set; }
    }

    public class TVADTOOut
    {
        public int IdTVA { get; set; }
        public int TauxTVA { get; set; }
    }
}
