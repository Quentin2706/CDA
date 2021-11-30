using APIAeroport.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAeroport.Data.Dtos
{
    public class AvionDTO
    {
        public string Compagnie { get; set; }
        public string Type { get; set; }
    }

    public class AvionVolDTO : AvionDTO
    {
        public virtual ICollection<Vol> Vols { get; set; }
    }
}
