using System;

namespace exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.1
            Console.Write("Saisissez un charactere : ");
            char value = char.Parse(Console.ReadLine());
            Console.WriteLine((char)((int)value + 1));

            //2.2
            char val1 = '0';
            char val2 = '1';
            char val3 = '2';
            char val4 = '3';
            char val5 = '4';
            char val6 = '5';
            char val7 = '6';
            char val8 = '7';
            char val9 = '8';
            char val10 = '9';

            Console.WriteLine((int)val1);
            Console.WriteLine((int)val2);
            Console.WriteLine((int)val3);
            Console.WriteLine((int)val4);
            Console.WriteLine((int)val5);
            Console.WriteLine((int)val6);
            Console.WriteLine((int)val7);
            Console.WriteLine((int)val8);
            Console.WriteLine((int)val9);
            Console.WriteLine((int)val10);

            // 2.3
            //Console.Write("Saisissez le nombre de kilos que le camion peut transporter : ");
            //float m = float.Parse(Console.ReadLine());
            //Console.Write("Saisissez le nombre de kilos par carton : ");
            //float k = float.Parse(Console.ReadLine());

            //float result = m / k;

            //Console.WriteLine("Le camion peut transporter " + (int) result + " cartons.");
        }
    }
}
