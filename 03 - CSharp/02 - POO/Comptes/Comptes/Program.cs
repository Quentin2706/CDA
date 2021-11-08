using System;

namespace Comptes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sommeValide;
            double somme;

            Console.WriteLine("Compte n°"+ Comptes.GetNbCompte());
            Console.WriteLine("Donner le CIN :");
            string cin = Console.ReadLine();

            Console.WriteLine("Donner le nom :");
            string nom = Console.ReadLine();

            Console.WriteLine("Donner le prenom :");
            string prenom = Console.ReadLine();

            Console.WriteLine("Donner le numéro de téléphone :");
            string tel = Console.ReadLine();

            Clients c = new Clients(cin, nom, prenom, tel);

            Comptes compte = new Comptes(0, c);
            Console.WriteLine(compte.Afficher()) ;

            Console.WriteLine();

            Clients c2 = new Clients("dadzada", "Dupont", "toto","");
            Comptes compte2 = new Comptes(556.20, c2);
            Console.WriteLine(compte2.Afficher());

            do
            {
                Console.Write("Donner le montant à déposer : ");
                sommeValide = double.TryParse(Console.ReadLine(), out somme);

                if (somme > compte2.GetSolde())
                    Console.WriteLine("Vous essayez de donner plus que ce que vous avez sur le compte n°"+compte2.Code);

            } while (!sommeValide || somme < 0 || somme > compte2.GetSolde());
            compte.Crediter(somme, compte2);
            Console.WriteLine("Opération bien effectuée.");
            Console.WriteLine(compte.Afficher());
            Console.WriteLine();
            Console.WriteLine(compte2.Afficher());


            Console.WriteLine("Nombre de comptes crées : " + Comptes.GetNbCompte());


        }
    }
}
