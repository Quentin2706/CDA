using APIGestionCommande.Data.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace APIGestionCommande.Data.Dtos
{
    public partial class PreparationDTO
    {
        public int IdProduit { get; set; }
        public int IdCommande { get; set; }
        public DateTime DatePreparation { get; set; }
    }

    public partial class PreparationDTOListe
    {
        public DateTime DatePreparation { get; set; }
        public virtual CommandeDTO Commande { get; set; }
        public virtual ProduitDTO Produit { get; set; }
    }

    public partial class PreparationProduitDTO
    {
        //public PreparationProduitDTO()
        //{
        //    Produit = new HashSet<ProduitDTO>();
        //}

        public DateTime DatePreparation { get; set; }
        public virtual ProduitDTO Produit { get; set; }
    }

    public partial class PreparationCommandeDTO
    {
        //public PreparationProduitDTO()
        //{
        //    Produit = new HashSet<ProduitDTO>();
        //}

        public DateTime DatePreparation { get; set; }
        public virtual CommandeDTO Commande { get; set; }
    }


}
