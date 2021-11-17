using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat
{
    class De
    { 
        private static Random rand = new Random();
        public static int LanceLeDe()
        {
            return rand.Next(1, 7);
        }

    }
}
