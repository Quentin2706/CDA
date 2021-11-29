using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVilles.Data.Dtos
{
    public class DepartementsDTO
    {
        public string Nom { get; set; }

        public ICollection<VillesDTO> LesVilles { get; set; }
    }
}
