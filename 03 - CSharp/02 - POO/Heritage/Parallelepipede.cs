using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Parallelepipede : Rectangle
    {
        public double Hauteur { get; set; }

        public Parallelepipede(double longueur, double largeur, double hauteur) : base(longueur, largeur)
        {
            this.Hauteur = hauteur;
        }

        override public double Périmètre()
        {
            return (2*base.Périmètre()) + (4*this.Hauteur);
        }

        public double Volume()
        {
            return base.Aire()*this.Hauteur;
        }

        public string AfficherParallelepipede()
        {
            return "Hauteur : " + this.Hauteur + " - Périmètre : " + this.Périmètre() + " - Volume : " + this.Volume();
        }

    }
}
