using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Cercle
    {
        public double diamètre { get; set; }

        public Cercle(double diamètre)
        {
            this.diamètre = diamètre;
        }

        public double Périmètre()
        {
            return Math.PI * this.diamètre;
        }

        public double Aire()
        {
            return Math.PI * Math.Pow((diamètre/2),2);
        }

        public string AfficherCercle()
        {
            return "Diamètre : " + this.diamètre + " - Périmètre : " + this.Périmètre() + " - Aire : " + this.Aire();
        }
    }
}
