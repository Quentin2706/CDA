using GestionStock.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Data.Dtos
{
    public class CategorieDTOOut
    {
        public int IdCategorie { get; set; }
        public string LibelleCategorie { get; set; }
        //public virtual TypeProduit TypeProduit { get; set; }
        //public virtual ICollection<Article> Articles { get; set; }
    }

    public class CategorieDTOIn
    {
        public string LibelleCategorie { get; set; }
        public int IdTypeProduit { get; set; }
    }
}
