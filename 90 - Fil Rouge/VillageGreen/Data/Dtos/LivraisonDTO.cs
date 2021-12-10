using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageGreen.Data.Dtos
{
    public class LivraisonDTOIn
    {
        public int IdCommande { get; set; }
        public int IdAdresse { get; set; }
        public DateTime DateLivraison { get; set; }
        public int QuantiteLivraison { get; set; }
    }

    public class LivraisonDTOOut
    {
        public int IdLivraison { get; set; }
        public int IdCommande { get; set; }
        public string NumeroCommande { get; set; }
        public DateTime DateCommande { get; set; }
        public int IdUser { get; set; }
        public string RefClient { get; set; }
        public int IdAdresse { get; set; }
        public string TelMobile { get; set; }
        public string TelFixe { get; set; }
        public string AdressePostale { get; set; }
        public string Province { get; set; }
        public string ComplementAdresse { get; set; }
        public int IdVille { get; set; }
        public int LibelleVille { get; set; }
        public string CodePostal { get; set; }
        public DateTime DateLivraison { get; set; }
        public int QuantiteLivraison { get; set; }
    }

    public class LivraisonDetailDTOOut
    {
        public int IdLivraison { get; set; }
        public int IdCommande { get; set; }
        public string NumeroCommande { get; set; }
        public DateTime DateCommande { get; set; }
        public int IdUser { get; set; }
        public string RefClient { get; set; }
        public int CoefClient { get; set; }
        public int IdCategorieClient { get; set; }
        public string LibelleCategClient { get; set; }
        public int IdAdresse { get; set; }
        public string EmailAdresse { get; set; }
        public string TelMobile { get; set; }
        public string TelFixe { get; set; }
        public string AdressePostale { get; set; }
        public string Province { get; set; }
        public string ComplementAdresse { get; set; }
        public int IdVille { get; set; }
        public int LibelleVille { get; set; }
        public string CodePostal { get; set; }
        public int IdPays { get; set; }
        public string NomPays { get; set; }
        public DateTime DateLivraison { get; set; }
        public int QuantiteLivraison { get; set; }
    }
}
