using System;
using System.IO;
namespace nomFichier
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"../../../test.txt";
            string[] donnees = new string[10];
            string[] donneesRecup = new string[10];

            static string[] creerTabDonnee(string[] tab)
            { 
                for(int i=0; i < 10 ;i++)
                {
                    tab[i] = i + " con";
                }

                return tab;
            }

            static void EcrireFichier(string path, string[] tab)
            { 
                File.WriteAllLines(path, tab);
            }

            donnees = creerTabDonnee(donnees);

            static void AfficheTab(string[] tab)
            { 
                foreach (string enregistrement in tab)
                {
                    Console.WriteLine(enregistrement);
                }
            }


            static string[] RecupDonnees(string path)
            {
                return File.ReadAllLines(path);
            }


            AfficheTab(donnees);
            EcrireFichier(path, donnees);
            Console.WriteLine();
            AfficheTab(RecupDonnees(path));





        }
    }
}
