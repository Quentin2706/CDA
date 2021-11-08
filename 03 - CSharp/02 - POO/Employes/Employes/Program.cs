using System;

namespace Employes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employes e1 = new Employes("DUPONT", "Jacques", new DateTime(2001,11,23), "vendeur", 20000, "Commercial");
            //Console.WriteLine(e1.Anciennete());

            if (DateTime.Now.Day == 30 && DateTime.Now.Month == 11)
            {
                e1.PrimeAnnuelle();
            }



        }
    }
}
