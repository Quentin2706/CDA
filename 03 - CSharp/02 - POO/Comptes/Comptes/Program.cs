using System;

namespace Comptes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sommeValide;
            double somme;

            Console.WriteLine("Compte n°"+Comptes.GetCodeIncremente());
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
            Console.WriteLine(compte.Afficher()) ;


            Clients c2 = new Clients("dadzada", "Dupont", "toto");
            Comptes compte2 = new Comptes(1000, c2);
            Console.WriteLine(compte.Afficher());

            do
            {
                Console.Write("Entrez le montant  à créditer pour le compte " + c + " : ");
                sommeValide = double.TryParse(Console.ReadLine(), out somme);
            } while (!sommeValide || somme < 0);
            compte.Crediter(somme, compte2);
            Console.WriteLine("Virement du compte n°"+compte.GetCodeIncremente()+ " vers le compte n°"+compte2.GetCodeIncremente()+" d'un montant de "+somme+" euros a été effectué.");





        }
    }
}
