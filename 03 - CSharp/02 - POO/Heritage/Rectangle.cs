using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Rectangle
    {
        public double Longueur { get; set; }
        public double Largeur { get; set; }

        public Rectangle(double longueur, double largeur)
        {
            Longueur = longueur;
            Largeur = largeur;
        }

        virtual public double Périmètre()
        {
            return (this.Longueur + this.Largeur) * 2;
        }

        public double Aire()
        {
            return (this.Longueur * this.Largeur);
        }

        public string EstCarre()
        {
            return this.Longueur == this.Largeur ? "Il s'agit d'un carré" : "Il ne s'agit pas d'un carré";
        }

        public string AfficherRectangle()
        {
            return "Longueur : " + this.Longueur + " - Largueur : " + this.Largeur + " - Périmètre : " + this.Périmètre() + " - Aire : " + this.Aire() +" - "+ this.EstCarre();
        }
    }
}
