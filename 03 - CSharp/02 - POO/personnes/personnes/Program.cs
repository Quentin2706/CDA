using System;

namespace personnes
{
    class Program
    {
        static void Main(string[] args)
        {
            Personnes p1 = new Personnes("Courquin", "Pierre", 21, "11 rue du chateau");
            Console.WriteLine(p1.ToString()); 

        }
    }
}
