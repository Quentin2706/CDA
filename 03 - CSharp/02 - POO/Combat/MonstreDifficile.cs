using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat
{
    class MonstreDifficile : MonstreFacile
    {

        override public int Attaque(bool trace)
        {
            int degats= base.Attaque(trace);
            int lance = De.LanceLeDe();


            if (lance != 6)
            {
                if (trace)
                    Console.WriteLine("Degats sort magique : "+lance * 5);

                return degats += lance * 5;

            }


            return degats;
        }




    }
}
