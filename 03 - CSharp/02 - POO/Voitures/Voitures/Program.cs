using System;

namespace Voitures
{
    class Program
    {
        static void Main(string[] args)
        {
            Voitures c4 = new Voitures("C4", "Citroen",1000);
            Voitures kadjar = new Voitures("Kadjar", "Renault","rouge");

            Console.WriteLine(c4);
            Console.WriteLine(kadjar);

            c4.Rouler(99);
            Console.WriteLine(c4);
        }
    }
}
