using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string test;
            Console.Write("entre un truc :");
            test = Console.ReadLine();
            Console.WriteLine("Result : "+test+" voila");
            Console.WriteLine();*/
            //Console.WriteLine(Program.Fonction());

            // 1 - Variables 
            // 1.1.1
            /*string nom;

            Console.Write("Saisissez votre nom : ");
            nom = Console.ReadLine();
            Console.Write("Votre nom est :" + nom);*/

            //1.1.2

            /*string entier;

            Console.Write("Saisir un entier : ");
            entier = Console.ReadLine();
             try
            {
                Convert.ToInt32(entier);
                Console.Write("Votre entier est : " + entier);
            } 
            catch
            {
                Console.Write("Votre entier n'est pas un entier");
            }*/

            // 1.2.1

/*            string value1;
            string value2;
            int val1 = 0;
            int val2 = 0;
            bool flag;

            do
            {
                Console.WriteLine("Valeur 1 :");
                value1 = Console.ReadLine();

                try
                {
                    val1 = Convert.ToInt32(value1);
                    flag = true;
                }
                catch
                {
                    Console.WriteLine("\nVALEUR INCORRECTE");
                    flag = false;
                }
            } while (!flag);

            do
            {
                Console.WriteLine("Valeur 2 :");
                value2 = Console.ReadLine();

                try
                {
                    val2 = Convert.ToInt32(value2);
                    flag = true;
                }
                catch
                {
                    Console.WriteLine("\nVALEUR INCORRECTE");
                    flag = false;
                }
            } while (!flag);

            int result1 = val1 + val2;
            int result2 = val1 / val2;
            Console.WriteLine("La somme des deux est : " + result1);
            Console.WriteLine("Le quotient des deux valeurs est : " + result2);*/

        }

        static int Fonction()
        {
            int test = 3;
            return test;
        }
    }
}
