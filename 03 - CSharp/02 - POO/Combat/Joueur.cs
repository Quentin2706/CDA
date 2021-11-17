using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat
{
    class Joueur
    {
        public int PDV { get; private set; }

        public Joueur()
        {
            this.PDV = 50;
        }


        public bool EstVivant()
        {
            if(this.PDV <= 0)
            {
                return false;
            }
            return true;
        }

        public bool Attaque(MonstreFacile monstre, bool trace)
        {
            int joueur = De.LanceLeDe();
            int m = De.LanceLeDe();

            if (trace)
                Console.WriteLine("Mon héros : "+joueur + "          Monstre : "+m);

            if (joueur >= m)
            {
                monstre.Etat = false;
                return true;
            }
            return false;
        }

        public bool SubitDegats(int dommages)
        {
            if (De.LanceLeDe() > 2)
            {
                this.PDV -= dommages;
                return true;
            }
            return false;
        }
    }
}
