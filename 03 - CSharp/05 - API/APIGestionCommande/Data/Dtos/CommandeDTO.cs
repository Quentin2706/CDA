using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGestionCommande.Data.Dtos
{
    public class CommandeDTO
    {
        public DateTime DateCommande { get; set; }
        public int NumeroCommande { get; set; }

        
    }
    public partial class CommandePreparationDTO : CommandeDTO
        {
            public virtual ICollection<PreparationDTO> Preparations { get; set; }
        }
}
