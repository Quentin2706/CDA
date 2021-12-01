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


    public class CommandeProduitDTO : CommandeDTO
    {
        public virtual ICollection<ProduitDTO> Produit { get; set; }
    }


    public partial class CommandePreparationDTO : CommandeDTO
        {
            public virtual ICollection<PreparationProduitDTO> Preparations { get; set; }
        }
}
