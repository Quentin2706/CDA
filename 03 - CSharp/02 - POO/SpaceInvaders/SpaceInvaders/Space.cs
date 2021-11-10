using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class Space
    {
        public int NbLignes { get; set; }
        public int NbColonnes { get; set; }
        public char[,] Grille { get; set; }
        public char[] temp { get; set; }
        public Invader Invader { get; set; }
        public Space(int nbLignes, int nbColonnes, Invader invader)
        {
            this.NbLignes = nbLignes;
            this.NbColonnes = nbColonnes;
            this.Grille = new char[nbLignes,nbColonnes];
            this.Invader = invader;
            this.CreerGrille();
        }

        private void CreerGrille()
        {
                for (int i = 0; i < this.NbLignes; i++)
                {
                    for (int j = 0; j < this.NbColonnes; j++)
                    {
                        this.Grille[0, j] = Convert.ToChar(Invader.ToString());
                        this.Grille[i, j] = ' ';
                    }
                }
        }


        public void tirer(int missile)
        {
            if (missile >= 0 && missile < this.NbColonnes)
            { 
                int cpt = this.NbLignes - 1;
            do
            {
                this.Grille[cpt, missile] = '^';
                
                Console.WriteLine(this.ToString());
                if (cpt < this.NbLignes)
                    this.Grille[cpt++, missile] = ' ';
                cpt-=2;
                Thread.Sleep(1000);
            } while (cpt >= 0);
            this.Grille[0, missile] = ' ';
            Console.WriteLine(this.ToString()); 
            } else
            {
                Console.WriteLine("Tu es en dehors de l'espace ! :o ");
            }
        }





        public override string ToString()
        {
            Console.Clear();
            string aff = "";
            string aff2 = "";
            for (int i = 0; i < this.NbColonnes; i++)
            {
                aff2 += "─";
            }

            aff += "┌" + aff2 + "┐" + "\n";

            for (int i = 0; i < this.NbLignes; i++)
            {
                aff += "|";
                for (int j = 0; j < this.NbColonnes; j++)
                {
                    aff += Grille[i, j];

                }
                aff += "|\n";

            }

            aff += "└" + aff2 + "┘" + "\n";
            return aff;
        }
    }

}
