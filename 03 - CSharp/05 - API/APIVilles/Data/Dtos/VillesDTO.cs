using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVilles.Data.Dtos
{
    public class VillesDTO
    {
        public string Nom { get; set; }
        public DepartementsDTO departement { get; set; }
    }
}
