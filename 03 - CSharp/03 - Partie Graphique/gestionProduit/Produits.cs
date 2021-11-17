using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionProduit
{


    class Produits
    {    
        
        public int IdProduit { get; set; }

        public string LibelleProduit { get; set; }

        public string Catégorie { get; set; }
        public string Rayon { get; set; }

        public Produits(int idProduit, string libelleProduit, string catégorie, string rayon)
        {
            IdProduit = idProduit;
            LibelleProduit = libelleProduit;
            Catégorie = catégorie;
            Rayon = rayon;
        }
    }
}
