using System;

namespace exo4
{
    class Program
    {
        static void Main(string[] args)
        {

            // 2.1
            //int nb;
            //bool val;

            //do
            //{
            //    Console.Write("Entrez une valeur entière : ");
            //    val = int.TryParse(Console.ReadLine(), out nb);
            //} while (!val || nb < 0);

            //for (int i = nb-1; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //2.2
            //int nb;
            //bool val;
            //int result;


            //do
            //{
            //    Console.Write("Entrez une valeur entière : ");
            //    val = int.TryParse(Console.ReadLine(), out nb);
            //    result = nb;

            //} while (!val);

            //for (int i = 1; i < nb; i++)
            //{
            //        result *= i;
            //        Console.WriteLine(result);
            //}



            // 3.1
            //int nb;
            //bool val;


            //do
            //{
            //    Console.Write("Entrez une valeur entière : ");
            //    val = int.TryParse(Console.ReadLine(), out nb);
            //} while (!val || nb < 0);

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(nb + " x " + i + " = " + (nb * i));
            //}


            //int[,] tab = new int[2, 10] {
            //    { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
            //    { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
            //};


            //for (int i = 0; i <= tab.GetLength(1); i++)
            //{
            //    for (int j = 0; j <= tab.GetLength(1); j++)
            //    {
            //        Console.WriteLine(i + " x " + j + " = " + (i * j));
            //    }
            //    Console.WriteLine();
            //}


            //int nb;
            //int nb2;
            //bool val;

            //do
            //{
            //    Console.Write("Entrez une valeur entière : ");
            //    val = int.TryParse(Console.ReadLine(), out nb);
            //    Console.Write("Entrez une valeur entière : ");
            //    val = int.TryParse(Console.ReadLine(), out nb2);
            //} while (!val || nb2 <= 0 );

            //Console.WriteLine(nb + "^" + nb2 + " = " + Math.Pow(nb, nb2));



            //int nb;
            //bool val;


            //do
            //{
            //    Console.Write("Entrez une valeur entière : ");
            //    val = int.TryParse(Console.ReadLine(), out nb);
            //} while (!val || nb <= 0);


            //for (int i = 0; i < nb; i++)
            //{
            //    for (int j = 0; j < nb; j++)
            //    {
            //        Console.Write("\tx");
            //    }
            //    Console.WriteLine();
            //}



            // Calculette


            //double nb;
            //double nb2;
            //int nb3;
            //bool val;
            //char op;
            //double result;
            //bool flag;
            //bool flagKey;

            //flag = true;
            //flagKey = false;
            //result = 0;
            //nb = 0;
            //nb2 = 0;
            //nb3 = 0;
            //val = false;

            //do
            //{

            //    if (flag)
            //    {
            //        Console.Write("Entrez une valeur : ");
            //        val = double.TryParse(Console.ReadLine(), out nb);
            //        flag = false;
            //    }

            //    if (val || !flag)
            //    {
            //        Console.Write("Entrez un opérateur : ");
            //        val = char.TryParse(Console.ReadLine(), out op);
            //        if (val)
            //        {
            //            if (op != 'V' && op != '?')
            //            {
            //                if (op != '$')
            //                {
            //                    Console.Write("Entrez une valeur : ");
            //                    val = double.TryParse(Console.ReadLine(), out nb2);
            //                }
            //                else
            //                {
            //                    do
            //                    {
            //                        Console.Write("Entrez une valeur entière : ");
            //                        val = int.TryParse(Console.ReadLine(), out nb3);
            //                    } while (!val);

            //                }
            //            }
            //            switch (op)
            //            {
            //                case '+':
            //                    result = nb + nb2;
            //                    break;
            //                case '-':
            //                    result = nb - nb2;
            //                    break;
            //                case '/':
            //                    result = nb / nb2;
            //                    break;
            //                case '*':
            //                    result = nb * nb2;
            //                    break;

            //                case '$':
            //                    result = Math.Pow(nb, nb3);
            //                    break;

            //                case 'V':
            //                    result = Math.Sqrt(nb);
            //                    break;

            //                case '!':
            //                    result = nb;
            //                    for (int i = 1; i < nb; i++)
            //                    {
            //                        result *= i;
            //                    }
            //                    break;

            //                default:
            //                    val = false;
            //                    break;
            //            }

            //            if (val)
            //            {
            //                Console.WriteLine(" = " + result);

            //                if (!flag)
            //                {
            //                    nb = result;
            //                    val = true;
            //                }
            //            }
            //        }
            //    }

            //    if (val)
            //    {
            //        Console.WriteLine("Arrêter le calcul ? Press Enter");
            //        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            //        {
            //            flagKey = true;
            //        }
            //    }


            //} while (!val || !flagKey);

            //Console.Write("Le résultat final est : " + result);

        }


        public static int demanderEntierPositif(string texte)
        {
            int valeur;
            bool conversionReussie;
            do
            {
                Console.WriteLine(texte);
                conversionReussie = int.TryParse(Console.ReadLine(), out valeur);

            } while (!conversionReussie || valeur < 0);
            return valeur;
        }

        static double demanderDouble(string texte)
        {
            double nb;
            bool ok;
            do
            {
                Console.Write(texte);
                ok = double.TryParse(Console.ReadLine(), out nb);
            } while (!ok);
            return nb;
        }

        public static double demanderDoubleNonNull(string texte)
        {
            double n;
            bool conversionReussie;
            do
            {
                Console.WriteLine(texte);
                conversionReussie = double.TryParse(Console.ReadLine(), out n);
            } while (!conversionReussie || n != 0);
            return n;
        }


        static char DemanderOperateur()
        {
            bool ok = true;
            char op;
            bool condition;

            do
            {
                Console.Write("Entrez un opérateur +,-,*,/,$,!,V : ");
                ok = char.TryParse(Console.ReadLine(), out op);
                condition = !ok || (op != '+' && op != '-' && op != '*' && op != '/' && op != '$' && op != '!' && op != 'V' && op != 'v');
                if (condition)
                    Console.WriteLine("Saisie incorrecte.");

            } while (condition);
            return char.ToUpper(op);
        }


        static double calculSimple(double valeur1, char operateur, double valeur2)
        {
            double resultat;
            resultat = 0;
            switch (operateur)
            {
                case '+':
                    resultat = valeur1 + valeur2;
                    break;
                case '-':
                    resultat = valeur1 - valeur2;
                    break;
                case '*':
                    resultat = valeur1 * valeur2;
                    break;
                case '/':
                    resultat = valeur1 / valeur2;
                    break;
                case '$':
                    resultat = Math.Pow(valeur1, valeur2);
                    break;
                default:
                    break;
            }
            return resultat;
        }

        static double Calcul(double valeur, char operateur)
        {
            double result;
            result = 0;

            switch (operateur)
            {
                case 'V':
                    result = Math.Sqrt(valeur);
                    break;

                case '!':
                    result = Math.Round(valeur);
                    for (int i = 1; i < valeur; i++)
                    {
                        result *= i;
                    }
                    break;
            }
            return result;
        }

    }
}
