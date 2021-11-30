using APIAeroport.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAeroport.Data.Dtos
{
    public class TrajetDTO
    {
        public string AeroportArrivee { get; set; }
        public string AeroportDepart { get; set; }
        public TimeSpan? DureeVol { get; set; }
    }

    public class TrajetVolDTO : TrajetDTO
    {
        public virtual ICollection<Vol> Vols { get; set; }
    }
    }
