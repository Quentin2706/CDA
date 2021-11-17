using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat
{
    class MonstreFacile
    {
        public bool Etat { get; set; } = true;


        virtual public int Attaque(bool trace)
        {
            int joueur = De.LanceLeDe();
            int m = De.LanceLeDe();

            if (trace)
                Console.WriteLine("Monstre: " + m  + "              Mon héros: " + joueur );

            if (joueur < m)
            {
                return 10;
            }
            return 0;
        }

    }
}
