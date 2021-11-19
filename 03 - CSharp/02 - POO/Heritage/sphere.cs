using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class sphere : Cercle
    {
        public sphere(double diamètre) : base(diamètre)
        {
        }

        public double Volume()
        {
            return Math.PI*0.75*Math.Pow((base.diamètre/2),2);
        }

        public string AfficherParallelepipede()
        {
            return " - Volume : " + this.Volume();
        }
    }
}
