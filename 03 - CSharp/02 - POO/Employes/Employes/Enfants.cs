using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employes
{
    class Enfants
    {
        public string Prenom { get; set; }
        public DateTime DDN { get; set; }

        public Enfants(string prenom, DateTime ddn)
        {
            this.Prenom = prenom;
            this.DDN = ddn;
        }

        public int Age()
        {
            DateTime aujd = DateTime.Now;
            TimeSpan diffResult = aujd - this.DDN;
            return (int)(diffResult.TotalDays / 365);
        }

        public int ChequesNoel()
        {
            if (Age() <= 10)
            {
                return 20;
            } else if (Age() <= 15)
            {
                return 30;
            } else if (Age() <= 18)
            {
                return 50;
            }
            return 0;
        }
    }
}
