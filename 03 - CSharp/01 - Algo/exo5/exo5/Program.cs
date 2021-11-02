using System;

namespace exo5
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1
            //string fff;
            //fff = "Les framboises sont perchées sur le tabouret de mon grand-père.";

            //for (int i = 0; i <= fff.Length; i++)
            //{
            //    Console.WriteLine(fff[i]);
            //}


            //// 2
            //bool val;
            //string t;
            //int ti;
            //int tj;
            //string result;
            //result = "";

            //Console.Write("saisissez une chaine de caractères : ");
            //t = Console.ReadLine();
            //do
            //{
            //    Console.Write("saisissez ti : ");
            //    val = int.TryParse(Console.ReadLine(), out ti);

            //    Console.Write("saisissez tj : ");
            //    val = int.TryParse(Console.ReadLine(), out tj);

            //   if (!val)
            //   {
            //        Console.WriteLine("Entrez une valeur positive");
            //   }
            //} while (!val || ti < 0 || tj < 0 || tj<ti || ti > t.Length || tj > t.Length);

            //for (int i = ti; i < tj; i++)
            //{
            //    result += t[i];
            //}
            //Console.Write(t+" "+result);

            //3
            //bool val;
            //string t;
            //int ti;
            //int tj;
            //string temp;
            //temp = "";


            //Console.Write("saisissez une chaine de caractères : ");
            //t = Console.ReadLine();

            //do
            //{
            //    Console.Write("saisissez ti : ");
            //    val = int.TryParse(Console.ReadLine(), out ti);

            //    Console.Write("saisissez tj : ");
            //    val = int.TryParse(Console.ReadLine(), out tj);

            //    if (!val)
            //        Console.WriteLine("Entrez une valeur positive");

            //} while (!val || ti < 0 || tj < 0 || tj < ti || ti > t.Length || tj > t.Length);

            //for (int i = ti; i < tj; i++)
            //{
            //    temp += t[i];
            //}

            //Console.Write(t.Insert(t.Length," "+temp));



            // 4
            //string t;
            //string a;
            //string b;


            //Console.Write("saisissez une chaine de caractères : ");
            //t = Console.ReadLine();

            //Console.Write("La lettre que vous voulez changer : ");
            //a = Console.ReadLine();

            //Console.Write("la lettre que vous voulez remplacer par "+a+" : ");
            //b = Console.ReadLine();


            //Console.WriteLine(t.Replace(a, b));

            // 5
            //string t;
            //string a;
            //string b;


            //Console.Write("saisissez une chaine de caractères : ");
            //t = Console.ReadLine();

            //Console.Write("La lettre que vous voulez changer : ");
            //a = Console.ReadLine();

            //Console.Write("la lettre que vous voulez remplacer par "+a+" : ");
            //b = Console.ReadLine();


            //Console.WriteLine(t.Replace(a, b));

            //6
            string t;
            int index;

            Console.WriteLine("Entrez le nom d'un fichier : ");
            t = Console.ReadLine();

            index = t.LastIndexOf(".");


            Console.WriteLine("nom de fichier : " + t.Substring(0, index));
            Console.WriteLine("Extension : " + t.Substring(index));


        }
    }
}
