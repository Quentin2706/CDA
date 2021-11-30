using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVilles.Data.Dtos
{
    public class VillesDTOListe
    {
        public string Nom { get; set; }

        public DepartementsDTOListe Dept { get; set; }
    }
}
