using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionProduit
{


    public class Produits
    {    
        
        public string IdProduit { get; set; }

        public string LibelleProduit { get; set; }

        public string Categorie { get; set; }
        public string Rayon { get; set; }

        public Produits(string idProduit, string libelleProduit, string categorie, string rayon)
        {
            IdProduit = idProduit;
            LibelleProduit = libelleProduit;
            Categorie = categorie;
            Rayon = rayon;
        }

        public Produits()
        {
        }
    }
}
