using System;
using System.Collections.Generic;

#nullable disable

namespace APIGestionCommande.Data.Dtos
{
    public partial class ProduitDTO
    {

        public string LibelleProduit { get; set; }
        public decimal PrixProduit { get; set; }
        public int QuantiteProduit { get; set; }

    }
    public partial class ProduitPreparationDTO : ProduitDTO
    {
        public ProduitPreparationDTO()
        {
            Preparations = new HashSet<PreparationCommandeDTO>();
        }

        public virtual ICollection<PreparationCommandeDTO> Preparations { get; set; }
    }
}
