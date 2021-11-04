using System;

namespace exo6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4
            //int[] t = new int[10] {1,2,3,4,5,6,7,8,9,10};

            //foreach (int elem in t)
            //{
            //    Console.Write(elem);
            //}

            // 5
            //int[] t = new int[10];

            //for (int i = 1; i <= t.Length; i++)
            //{
            //    t[i-1] = i;
            //}
            //foreach (int elem in t)
            //{
            //    Console.Write(elem);
            //}

            // 6 
            //int sum = 0;
            //int[] t = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //foreach (int elem in t)
            //{
            //    sum += elem;

            //}
            //Console.Write(sum);


            // 7
            //int[] t = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int cpt = 0;

            //Console.WriteLine("Donner un chiffre :");
            //int value = int.Parse(Console.ReadLine());

            //while (cpt < t.Length && t[cpt] != value)
            //{
            //    cpt++;
            //}

            //if (cpt < t.Length)
            //{
            //    Console.WriteLine("Bien joué !");
            //}
            //else
            //{
            //    Console.WriteLine("Le chiffre n'est pas dans le tableau.");
            //}

            // 8
            // int[] t = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] tt = new int[10];

            //int nb = 1;

            //for (int i = 0; i < t.Length - nb; i++)
            //{
            //    tt[i] = t[i + nb];
            //}

            //for (int i = t.Length - nb; i < t.Length; i++)
            //{
            //    tt[i] = t[i - (t.Length - nb)];
            //}

            //foreach (var elem in t)
            //{
            //    Console.Write(elem);
            //}
            //Console.WriteLine();
            //foreach (var elem in tt)
            //{
            //    Console.Write(elem);
            //}

            //  Console.WriteLine();

            //9
            //int[] t = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int temp;
            //int n = 2;


            //do
            //{

            //    temp = t[t.Length-1];
            //    for (int i = t.Length - 1; i > 0; i--)
            //    {
            //        t[i] = t[i-1];
            //    }
            //    t[0] = temp;
            //    n--;
            //} while (n > 0);

            //foreach (var elem in t)
            //{
            //    Console.Write(elem);
            //}
            //Console.WriteLine();



            //10 
            //int[] t = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int temp;

            //for (int i = 0; i < t.Length/2; i++)
            //{
            //    temp = t[i];
            //    t[i] = t[t.Length - 1 - i];
            //    t[t.Length - 1 - i] = temp;
            //}

            //foreach (var elem in t)
            //{
            //    Console.Write(elem);
            //}


            // 11 

            //int[] t = new int[20];

            //for (int i = 0; i < t.Length; i++)
            //{
            //    t[i] = (i * i) % 17;
            //}
            //foreach (var elem in t)
            //{
            //    Console.Write(elem + " ");
            //}



            // 12
            //int[] t = new int[20];

            //for (int i = 0; i < t.Length; i++)
            //{
            //    t[i] = (i * i) % 17;
            //}


            //int min = t[0];
            //int max = t[0];
            //for (int i = 0; i < t.Length; i++)
            //{
            //    if ( t[i] < min)
            //    {
            //        min = t[i];
            //    }

            //    if (t[i] > max)
            //    {
            //        max = t[i];
            //    }
            //}
            //Console.WriteLine("La valeur la plus petite est : " + min + " et la valeur la plus grande est : " + max);

            //foreach (var elem in t)
            //{
            //    Console.Write(elem + " ");
            //}


            // 13 
            //int nb;
            //Console.Write("Entrez une valeur : ");
            //nb = int.Parse(Console.ReadLine());

            //int[] t = new int[20];

            //for (int i = 0; i < t.Length; i++)
            //{
            //    t[i] = (i * i) % 17;
            //}


            //int[] result = new int[20];

            //for(int i = 0; i < t.Length; i++)
            //{
            //    if (t[i] == nb)
            //    {
            //        Console.WriteLine("L'indice " + i + " a pour valeur " + nb);
            //    }
            //}

            // 14 

            //int nb;
            //Console.Write("Entrez une valeur : ");
            //nb = int.Parse(Console.ReadLine());

            //int[] t = new int[20];

            //for (int i = 0; i < t.Length; i++)
            //{
            //    t[i] = (i * i) % 17;
            //}


            //int[] result = new int[20];
            //int cpt = 0;
            //for (int i = 0; i < t.Length; i++)
            //{
            //    if (t[i] == nb)
            //    {
            //        result[cpt] = i;
            //        cpt++;
            //    }
            //}

            //Array.Resize(ref result,cpt);

            //foreach (var elem in result)
            //{
            //    Console.WriteLine("L'indice " + elem + " a pour valeur " + nb);
            //}

            //0.5 0.2 0.1 0.05 0.01
            // 15 
            double montant;
            double[] stock = new double[6] { 0.5, 0.2, 0.1, 0.05, 0.02 , 0.01 };
            int[] total = new int[6];
            Console.Write("Entrez le montant : ");

            montant = double.Parse(Console.ReadLine());






            foreach (var elem in total)
            {
                Console.Write(elem + " ");
            }

            Console.Write(montant);



        }
    }
}
