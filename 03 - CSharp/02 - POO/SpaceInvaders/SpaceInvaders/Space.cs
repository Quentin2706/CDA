using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class Space
    {
        public int NbLignes { get; set; }
        public int NbColonnes { get; set; }
        public char[,] Grille { get; set; };

        public Space(int nbLignes, int nbColonnes)
        {
            this.NbLignes = nbLignes;
            this.NbColonnes = nbColonnes;
            this.Grille = new 
            for (int i = 0; i < this.NbLignes; i++)
            {
                for (int j = 0; j < this.NbColonnes; j++)
                {
                    temp = new();
                    temp.Add(' ');
                }
                Grille.Add(temp);
            }
        }


        public override string ToString()
        {
            string aff = "";
            int cpt = 0;
            int cpt2 = 0;
            aff += "[";

            //for (int i = 0; i < Grille.Count; i++)
            //{
            //    aff += "[";
            //    for (int j = 0; j < Grille[i].Count; j++)
            //    {
            //        aff += "'" + Grille[i[j]] + "'";
            //    }
            //    aff += "]";
            //    if (i < Grille.Count-1)
            //        aff += ",";

            //}
            foreach (var colonne in Grille)
            {
                aff += "[";
                foreach (char ligne in colonne)
                {
                    aff += "' '";
                    if (cpt2 < colonne.Count - 1)
                        aff += ",";
                    cpt2++;
                }
                aff += "]";
                if (cpt < Grille.Count - 1)
                    aff += ",";
                cpt++;
            }
            aff += "]";
            return aff;
        }
    }

}
