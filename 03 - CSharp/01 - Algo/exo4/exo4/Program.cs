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

            //for (int i = 1; i <= 10; i++)
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


            double nb;
            double nb2;
            int nb3;
            bool val;
            char op;
            double result;
            bool flag;
            bool flagKey;

            flag = true;
            flagKey = false;
            result = 0;
            nb = 0;
            nb2 = 0;
            nb3 = 0;
            val = false;

            do
            {

                if (flag)
                {
                    Console.Write("Entrez une valeur : ");
                    val = double.TryParse(Console.ReadLine(), out nb);
                    flag = false;
                }

                if (val || !flag)
                {
                    Console.Write("Entrez un opérateur : ");
                    val = char.TryParse(Console.ReadLine(), out op);
                    if (val)
                    {
                        if (op != '!' && op != '?')
                        { 
                            if (op != '$')
                            { 
                                Console.Write("Entrez une valeur : ");
                                val = double.TryParse(Console.ReadLine(), out nb2);
                            } else
                            {
                                do
                                {
                                    Console.Write("Entrez une valeur entière : ");
                                    val = int.TryParse(Console.ReadLine(), out nb3);
                                } while (!val);
                          
                            }
                        }
                        switch (op)
                        {
                            case '+':
                                result = nb + nb2;
                                break;
                            case '-':
                                result = nb - nb2;
                                break;
                            case '/':
                                result = nb / nb2;
                                break;
                            case '*':
                                result = nb * nb2;
                                break;

                            case '$':
                                result = Math.Pow(nb,nb3);
                                break;

                            case '!':
                                result = Math.Sqrt(nb);
                                break;

                            case '?':
                                result = nb;
                                for (int i = 1; i < nb; i++)
                                {
                                    result *= i;
                                }
                                break;

                            default:
                                val = false;
                                break;
                        }

                        if (val)
                        {
                            Console.WriteLine(" = " + result);

                            if (!flag)
                            {
                                nb = result;
                                val = true;
                            }
                        }
                    }
                }

                if (val)
                {
                    Console.WriteLine("Arrêter le calcul ? Press Enter");
                    if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                    {
                        flagKey = true;
                    }
                }
                

            } while (!val || !flagKey);

            Console.Write("Le résultat final est : "+result);
        }
    }
}
