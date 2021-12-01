using GestionStock.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Data.Dtos
{
    public class TypeProduitDTOOut
    {
        public int IdTypeProduit { get; set; }

        public string LibelleTypeProduit { get; set; }

        //public virtual ICollection<Categorie> Categories { get; set; }
    }

    public class TypeProduitDTOIn
    {
        public string LibelleTypeProduit { get; set; }
    }
}
