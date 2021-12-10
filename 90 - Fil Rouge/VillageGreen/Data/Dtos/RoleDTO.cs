using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageGreen.Data.Dtos
{
    public class RoleDTOIn
    {
        public string LibelleRole { get; set; }
    }

    public class RoleDTOOut
    {
        public int IdRole { get; set; }
        public string LibelleRole { get; set; }
    }
}
