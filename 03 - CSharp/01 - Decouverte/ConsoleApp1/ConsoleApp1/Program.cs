namespace ConsoleApp1
{
    using System;

    internal class Program
    {
        internal static void Main(string[] args)
        {
            //string test;
            //Console.Write("entre un truc :");
            //test = Console.ReadLine();
            //Console.WriteLine("Result : " + test + " voila");

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

            /*string value1;
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
            Console.WriteLine("La somme des deux est : " + result1);

            if (val2 != 0 || val1 != 0)
            {
                int result2 = val1 / val2;
                Console.WriteLine("Le quotient des deux valeurs est : " + result2);
            }
            else
            {
                Console.WriteLine("Une division par 0 est impossible.");
            }*/

            //1.3.1

            //string value;
            //bool flag;
            //double val;
            //do
            //{
            //    Console.WriteLine("Valeur :");
            //    value = Console.ReadLine();

            //    try
            //    {
            //        val = float.Parse(value);
            //        Console.WriteLine("\nVotre float est : "+val);
            //        flag = true;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("\nvaleur incorrecte");
            //        flag = false;
            //    }
            //} while (!flag);

            //1.3.2

            //Console.WriteLine("Saisissez 3 valeurs :");
            //string value1 = Console.ReadLine();
            //string value2 = Console.ReadLine();
            //string value3 = Console.ReadLine();

            //double moyenne = (float.Parse(value1) + float.Parse(value2) + float.Parse(value3)) / 3;

            //Console.WriteLine("La moyenne est de :" + Math.Round(moyenne,2));

            //1.3.3

            //Console.Write("Saisissez la longueur : ");
            //string value1 = Console.ReadLine();
            //Console.Write("Saisissez la largeur : ");
            //string value2 = Console.ReadLine();
            //double surface = float.Parse(value1) * float.Parse(value2);

            //Console.WriteLine("La surface du rectangle est :" + Math.Round(surface, 2));


            // 1.4.1

            //char character = 'a';
            //Console.WriteLine((int)character);

            // 1.4.2

            //Console.Write("Saisissez un charactere en minuscule : ");
            //string value = Console.ReadLine();
            //Console.Write(value.ToUpper());


            // 2.1
            Console.Write("Saisissez un charactere : ");
            char value = char.Parse(Console.ReadLine());
            Console.WriteLine((char) ((int) value+1));

            // 2.2
            char val 1 = 0;
            

















        }
    }
}
