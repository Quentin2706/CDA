using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageGreen.Data.Dtos
{
    public class PaysDTOIn
    {
        public string NomPays { get; set; }
    }

    public class PaysDTOOut
    {
        public int IdPays { get; set; }
        public string NomPays { get; set; }
    }
}
