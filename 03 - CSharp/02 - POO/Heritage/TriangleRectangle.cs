using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class TriangleRectangle
    {
        public double Base { get; set; }
        public double Hauteur { get; set; }

        public TriangleRectangle(double @base, double hauteur)
        {
            Base = @base;
            Hauteur = hauteur;
        }

        virtual public double Périmètre()
        {
            return this.Base + this.Hauteur + Math.Sqrt(Math.Pow(this.Hauteur, 2) + Math.Pow(this.Base, 2));
        }

        public double Aire()
        {
            return (this.Base * this.Hauteur) / 2;
        }

        public string AfficherTriangleRectangle()
        {
            return "Base : " + this.Base + " - Hauteur : " + this.Hauteur + " - Périmètre : " + this.Périmètre() + " - Aire : " + this.Aire();
        }
    }
}
