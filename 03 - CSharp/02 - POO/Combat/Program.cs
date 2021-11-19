using System;

namespace Combat
{
    class Program
    {
        static void Main(string[] args)
        {
            Joueur player = new Joueur();
            MonstreFacile monstre;
            int dmg;
            int cpt=0;

            bool trace = true;
            if (De.LanceLeDe() < 4)
            {
                monstre = new MonstreFacile();
            }
            else
            {
                monstre = new MonstreDifficile();
            }

            do
            {
                if(!monstre.Etat)
                { 
                    if (De.LanceLeDe() < 4)
                    {
                        monstre = new MonstreFacile();
                    } else
                    {
                        monstre = new MonstreDifficile();
                    }
                }


                if (player.Attaque(monstre,trace))
                {
                    cpt++;
                    Console.WriteLine("Le monstre est mort ! ");
                } else
                {
                    Console.WriteLine("Le joueur a raté sa cible ! ");
                    dmg = monstre.Attaque(trace);
                    if (dmg > 0)
                    {
                        if (player.SubitDegats(dmg))
                        {
                            Console.WriteLine("Le joueur a subit : " + dmg + " point de vie.");
                        } else
                        {
                            Console.WriteLine("le bouclier du joueur s'est déclenché !");
                        }
                    } else
                    {
                        Console.WriteLine("Le monstre a raté sa cible ! ");
                    }
                }
            } while (player.EstVivant());

            Console.WriteLine("Le joueur est mort ! Nombre de point de vie "+player.PDV);
            Console.WriteLine("Nombre de monstres tués :"+cpt);
        }
    }
}
