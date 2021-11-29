using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVilles.Data.Dtos
{
    public class VillesDTO
    {
        public string Nom { get; set; }

        public int IdDepartement { get; set; }
        public DepartementsDTO Dept { get; set; }
    }
}
