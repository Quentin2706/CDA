using System;

namespace exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1 .

            //Console.Write("Saisissez votre age : ");
            //string age = Console.ReadLine();
            //if (int.Parse(age) > 18)
            //{
            //    Console.WriteLine("Vous etes majeur.");
            //} else
            //{
            //    Console.WriteLine("Vous etes mineur.");
            //}

            //// 2. 

            //Console.Write("entrez un nombre :");

            //string value = Console.ReadLine();

            //if (value.StartsWith("-"))
            //{
            //    double result = double.Parse(value.Substring(1, value.Length - 1));
            //    Console.WriteLine("la valeur absolue  de "+value+" est : "+result);
            //} else
            //{
            //    double result = double.Parse(value);
            //    Console.WriteLine("la valeur absolue  de " + value + " est : " + result);
            //}

            //// 3.

            //Console.WriteLine("Saisissez une note :");
            //string value = Console.ReadLine();
            //double val = double.Parse(value);

            //if (val < 8 && val >= 0)
            //{
            //    Console.WriteLine("ajourné");
            //} else if (val >= 8 && val < 10)
            //{
            //    Console.WriteLine("rattrapage");
            //} elset
            //{
            //    Console.WriteLine("Admis");
            //}

            //// 4.
            //Console.Write("Saisissez le montant des dommages :");
            //string value = Console.ReadLine();
            //double franchise = double.Parse(value) * 0.1;
            //double total = double.Parse(value) + franchise;
            //if (franchise <= 4000)
            //{
            //    Console.WriteLine("La franchise est de "+ Math.Round(franchise,2) + " et le montant a remboursé est de "+ Math.Round(total,2));
            //} else
            //{
            //    Console.WriteLine("Le montant de la franchise des dommages est trop élevé, elle est de : "+ Math.Round(franchise,2));
            //}

            //5.

            //Console.Write("Saisissez deux valeurs :");
            //double value1 = Convert.ToDouble(Console.ReadLine());
            //double value2 = Convert.ToDouble(Console.ReadLine());

            //if (value1 == value2)
            //{
            //    Console.WriteLine("Il n'y a qu'une seule valeur distincte.");
            //}
            //else
            //{
            //    Console.WriteLine("Il y a deux valeurs distinctes.");
            //}


            // 6.


            //Console.Write("Saisissez trois valeurs :");
            //double value1 = Convert.ToDouble(Console.ReadLine());
            //double value2 = Convert.ToDouble(Console.ReadLine());
            //double value3 = Convert.ToDouble(Console.ReadLine());


            //if (value1 < value2 && value1 < value3)
            //{
            //    Console.WriteLine("la valeur n°1 : " + value1 + "est la plus petite valeur");
            //}
            //else
            //{
            //    if (value2 < value3 && value2 < value1)
            //    {
            //        Console.WriteLine("la valeur n°2 : "+value2 + " est la plus petite valeur");
            //    }
            //    else
            //    {
            //        Console.WriteLine("la valeur n°3 : " + value3 + "est la plus petite valeur");
            //    }

            //}

            // 7.
            //Console.Write("Saisissez trois valeurs entières : ");
            //int value1 = Convert.ToInt32(Console.ReadLine());
            //int value2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Saisissez un opérateur +,-,/,* : ");
            //char op =  Convert.ToChar(Console.ReadLine());

            //switch (op)
            //{
            //    case '-':
            //        Console.WriteLine("Le résultat est : "+(value1 - value2));
            //        break;

            //    case '*':
            //        Console.WriteLine("Le résultat est : " + (value1 * value2));
            //        break;

            //    case '/':
            //        Console.WriteLine("Le résultat est : " + Math.Round(((float) value1 / (float) value2),2));
            //        break;

            //    case '+':
            //        Console.WriteLine("Le résultat est : " + (value1 + value2));
            //        break;

            //    default:
            //        Console.Write("Opérateur incorrect.");
            //        break;
            //}


            // Echiquier

            // 8.
            //Console.WriteLine("Saisissez les coordonnées I et J : ");

            //int i = Convert.ToInt32(Console.ReadLine());
            //int j = Convert.ToInt32(Console.ReadLine());

            //if ((i+j)%2 == 0)
            //{
            //    Console.Write("La case est noire.");
            //} else
            //{
            //    Console.Write("La case est blanche.");
            //}

            // 9.
            //Console.WriteLine("Saisissez les coordonnées I et J de votre cavalier : ");

            //int i = Convert.ToInt32(Console.ReadLine());
            //int j = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Saisissez les coordonnées I et J du futur déplacement de votre cavalier : ");

            //int i2 = Convert.ToInt32(Console.ReadLine());
            //int j2 = Convert.ToInt32(Console.ReadLine());

            //if ( (i2 == i + 2 && j2 == j + 1) || (i2 == i + 2 && j2 == j - 1) || (i2 == i - 2 && j2 == j + 1) || (i2 == i - 2 && j2 == j - 1) || (j2 == j - 2 && i2 == i - 1) || (j2 == j - 2 && i2 == i + 1) || (j2 == j + 2 && i2 == i - 1) || (j2 == j + 2 && i2 == i + 1))
            //{
            //    Console.WriteLine("T'as le droit de bouger");
            //} else
            //{
            //    Console.WriteLine("T'as pas le droit de bouger");
            //}



            //10.

            //Console.WriteLine("Saisissez le pion a bouger : ");
            //string value = Console.ReadLine();


            //Console.WriteLine("Saisissez les coordonnées I et J le fou : ");

            //int i = Convert.ToInt32(Console.ReadLine());
            //int j = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Saisissez les coordonnées I et J du futur déplacement de votre cavalier : ");

            //int i2 = Convert.ToInt32(Console.ReadLine());
            //int j2 = Convert.ToInt32(Console.ReadLine());


            //switch (value)
            //{
            //    case "0":
            
            //        // le cavalier
            //        if ((i2 == i + 2 && j2 == j + 1) || (i2 == i + 2 && j2 == j - 1) || (i2 == i - 2 && j2 == j + 1) || (i2 == i - 2 && j2 == j - 1) || (j2 == j - 2 && i2 == i - 1) || (j2 == j - 2 && i2 == i + 1) || (j2 == j + 2 && i2 == i - 1) || (j2 == j + 2 && i2 == i + 1))
            //        {
            //            Console.WriteLine("T'as le droit de bouger");
            //        }
            //        else
            //        {
            //            Console.WriteLine("T'as pas le droit de bouger");
            //        }
            //        break;

            //    case "1":

            //        // la tour
            //        if (i != i2 && j == j2 || i == i2 && j != j2)
            //        {
            //            Console.WriteLine("T'as le droit de bouger");
            //        }
            //        else
            //        {
            //            Console.WriteLine("T'as pas le droit de bouger");
            //        }
            //        break;

            //    case "2":
            //        // le fou

            //        if (Math.Abs(i - i2) == Math.Abs(j - j2))
            //        {
            //            Console.WriteLine("T'as le droit de bouger");
            //        }
            //        else
            //        {
            //            Console.WriteLine("T'as pas le droit de bouger");
            //        }
            //        break;

            //    case "3":
            //        // la dame 
            //        if ((i != i2 && j == j2 || i == i2 && j != j2) || Math.Abs(i - i2) == Math.Abs(j - j2))
            //        {
            //            Console.WriteLine("T'as le droit de bouger");
            //        }
            //        else
            //        {
            //            Console.WriteLine("T'as pas le droit de bouger");
            //        }
            //        break;

            //    case "4":
            //        // Le roi
            //        if ((i == i2 - 1 && j == j2 - 1) || (i == i2 + 1 && j == j2 + 1) || (i == i2 - 1 && j == j2 + 1) || (i == i2 + 1 && j == j2 - 1) || (i == i2 - 1 && j == j2 - 1) || (i == i2 && j == j2 + 1) || (i == i2 && j == j2 - 1) || (i == i2 - 1 && j == j2) || (i == i2 + 1 && j == j2))
            //        {
            //            Console.WriteLine("T'as le droit de bouger");
            //        }
            //        else
            //        {
            //            Console.WriteLine("T'as pas le droit de bouger");
            //        }
            //    default:
            //        { 
            //        Console.WriteLine("Saisie incorrecte");
            //        break;
            //        }
            //}

            // 11.
            //Console.Write("Ecrivez l'heure de départ : ");
            //string departH = Console.ReadLine();

            //Console.Write("Ecrivez les minutes de départ : ");
            //string departM = Console.ReadLine();

            //Console.Write("Ecrivez l'heure d'arrivée : ");
            //string arriveeH = Console.ReadLine();

            //Console.Write("Ecrivez les minutes d'arrivée : ");
            //string arriveeM = Console.ReadLine();

            //int departHInt = Convert.ToInt32(departH);
            //int arriveeHInt = Convert.ToInt32(arriveeH);

            //int departMInt = Convert.ToInt32(departM);
            //int arriveeMInt = Convert.ToInt32(arriveeM);


            //// si les minutes d'arrivée sont plus petites que le départ
            //if (arriveeMInt - departMInt < 0)
            //{
            //    if (arriveeHInt - departHInt < 0)
            //    {
            //        Console.WriteLine("L'heure de départ est après l'heure d'arrivée ..");
            //    }
            //    else
            //    {
            //        if (arriveeHInt - departHInt != 0)
            //        { 
            //            int diffH = arriveeHInt - departHInt - 1;
            //            Console.WriteLine("Il y a " + diffH + " heure(s) et " + (60 - departMInt + arriveeMInt) + " minutes de différence.");
            //        } else {
            //            Console.WriteLine("Il y a 0 heure(s) et " + (60 - departMInt + arriveeMInt) + " minutes de différence.");
            //        }
                   
            //    }
            //} else
            //{
            //    if (arriveeHInt-departHInt < 0)
            //    {
            //        Console.WriteLine("L'heure de départ est après l'heure d'arrivée ..");
            //    } else
            //    {
            //        Console.WriteLine("Il y a " + (arriveeHInt - departHInt) + " heure(s) et " + (arriveeMInt - departMInt) + " minutes de différence.");
                //}
            
            //}

            // 12.

            //Console.Write("Ecrivez le jour : ");
            //string jour = Console.ReadLine();
            //int jourInt = Convert.ToInt32(jour);

            //Console.Write("Ecrivez le mois : ");
            //string mois = Console.ReadLine();
            //int moisInt = Convert.ToInt32(mois);

            //Console.Write("Ecrivez l'année : ");
            //string annee = Console.ReadLine();
            //int anneeInt = Convert.ToInt32(annee);

            //if ((anneeInt % 400 == 0 || anneeInt % 100 != 0) && (anneeInt % 4 == 0))
            //{
            //   if (moisInt == 2)
            //   {
            //        if (jourInt == 28)
            //        {
            //            jourInt++;
            //        }
            //   } else
            //    {
            //        if (moisInt%2)
            //    }


            //} else
            //{
                
            //}


        // 13.

        Console.WriteLine("Entrez deux valeurs :");
        string value1 = Console.ReadLine();
        string value2 = Console.ReadLine();





        }
    }
}
