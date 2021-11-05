using System;

namespace Comptes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donner le CIN :");
            string cin = Console.ReadLine();

            Console.WriteLine("Donner le nom :");
            string nom = Console.ReadLine();

            Console.WriteLine("Donner le prenom :");
            string prenom = Console.ReadLine();

            Console.WriteLine("Donner le numéro de téléphone :");
            string tel = Console.ReadLine();

            Clients c = new Clients(cin, nom, prenom, tel);

            Comptes compte = new Comptes(1000, c);


            Console.WriteLine("*******************");
            Console.WriteLine(compte.Afficher());
            Console.WriteLine("*******************");


        }
    }
}
