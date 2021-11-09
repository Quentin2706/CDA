using System;
using System.Collections.Generic;

namespace Employes
{
    class Program
    {
        static void Main(string[] args)
        {
            Enfants enf1 = new Enfants( "1", new DateTime(2008, 11, 23));
            Enfants enf2 = new Enfants("1", new DateTime(2020, 11, 23));
            Enfants enf3 = new Enfants("1", new DateTime(2000, 11, 23));
            Enfants enf4 = new Enfants("1", new DateTime(2004, 11, 23));


            Agences a1 = new Agences("agence1", "11 rue du chateau", "62540", "Jesaispas", "cantine");
            Agences a2 = new Agences("agence2", "40 rue du terrier", "54324", "Anywhere", "Tickets Restaurants");

            Employes e1 = new Employes("DUPONT", "Jacques", new DateTime(2008,11,23), "vendeur", 43000, "Commercial",a1, new List<Enfants> {enf1,enf2,enf3,enf4 });
            Employes e2 = new Employes("DUPONT", "Jacques", new DateTime(1991, 11, 23), "vendeur", 35000, "Zommercial",a2, new List<Enfants> {enf3, enf4 });
            Employes e3 = new Employes("BUPONT", "Jacques", new DateTime(2020, 11, 23), "vendeur",100000, "Commercial",a2);
            Employes e4 = new Employes("DUPONT", "Dacques", new DateTime(2006, 11, 23), "vendeur", 21952, "Bommercial",a1);
            Employes e5 = new Employes("DUPONT", "Jacques", new DateTime(2015, 11, 23), "vendeur", 23000, "Commercial",a1);

            List<Employes> tab = new List<Employes>()
                {
                        e1,
                        e2,
                        e3,
                        e4,
                        e5,
                };
            //Console.WriteLine(e1.Anciennete());
            if (DateTime.Now.Day == 30 && DateTime.Now.Month == 11)
            {
                for (int i = 0; i < Employes.NbEmploye; i++)
                {
                    Console.WriteLine("La prime annuelle de "+tab[i].Nom+" "+tab[i].Prenom+" d'un montant de "+tab[i].Prime()+"  a été envoyé pour isntructions à la banque.");
                }
            }

            tab.Sort(Employes.ComparerToNomPrenom);

            for (int i = 0; i < Employes.NbEmploye; i++)
            {
                Console.WriteLine(tab[i]);
            }

            Console.WriteLine("Le nombre d'employés crées : "+Employes.NbEmploye);

            tab.Sort(Employes.ComparerToService);

            for (int i = 0; i < Employes.NbEmploye; i++)
            {
                Console.WriteLine(tab[i]);
            }

            Console.WriteLine("La masse salariale est de : "+Employes.MasseSalariale(tab)+" euros.");

        }
    }
}
