using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAeroport.Data.Dtos
{
    public class VolDTO
    {
        public int? IdPilote { get; set; }
        public int? IdTrajet { get; set; }
        public int? IdAvion { get; set; }
        public DateTime? DateVol { get; set; }
    }


}
