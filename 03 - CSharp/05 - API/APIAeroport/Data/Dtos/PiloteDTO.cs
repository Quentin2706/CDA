using APIAeroport.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAeroport.Data.Dtos
{
    public class PiloteDTO
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
    }

    public class PiloteVolDTO : PiloteDTO
    {
        public virtual ICollection<Vol> Vols { get; set; }
    }
}
