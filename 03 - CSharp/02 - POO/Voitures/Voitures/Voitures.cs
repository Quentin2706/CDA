using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voitures
{
    class Voitures
    {
        public string Couleur { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public int NbKilometre { get; set; }
        public string Motorisation { get; set; }

        public Voitures(string marque, string modele)
        {
            Marque = marque;
            Modele = modele;
        }

        public Voitures( string marque, string modele, string couleur)
        {
            Marque = marque;
            Modele = modele;
            Couleur = couleur;
        }

        public Voitures(string marque, string modele, int nbKilometre) 
        {
            Marque = marque;
            Modele = modele;
            NbKilometre = nbKilometre;
        }


        public int Rouler(int km)
        {
            return this.NbKilometre += km;
        }



        override public string ToString()
        {
            return "Cette voiture est une " + this.Modele + " de la marque " + this.Marque+ ", de couleur " + this.Couleur + ", de motorisation " + this.Motorisation + ", avec " + this.NbKilometre + " Kilomètres";
        }
    }
}
