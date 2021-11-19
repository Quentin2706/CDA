using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Pyramide : TriangleRectangle
    {
        public double Profondeur { get; set; }

        public Pyramide(double @Base,double hauteur ,double profondeur) : base(@Base, hauteur)
        {
            Profondeur = profondeur;
        }

        override public double Périmètre()
        {
            return 2*base.Périmètre() + 3*this.Profondeur;
        }

        public double Volume()
        {
            return base.Aire() * this.Profondeur;
        }

        public string AfficherPyramide()
        {
            return "Profondeur : " + this.Profondeur + " - Périmètre : " + this.Périmètre() + " - Volume : " + this.Volume();
        }
    }
}
