using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employes
{
    class Employes
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateEmbauche { get; set; }
        public string Fonction { get; set; }
        public double SalaireAnnuel { get; private set; }
        public string Service { get; set; }
        public Agences Agence { get; set; }
        public List<Enfants> Enfants { get; set; } = new List<Enfants>();


        public Employes(string nom, string prenom, DateTime dateEmbauche, string fonction, double salaireAnnuel, string service, Agences agence, List<Enfants> enfants)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateEmbauche = dateEmbauche;
            this.Fonction = fonction;
            this.SalaireAnnuel = salaireAnnuel;
            this.Service = service;
            this.Agence = agence;
            this.Enfants = enfants;
        }

        public Employes(string nom, string prenom, DateTime dateEmbauche, string fonction, double salaireAnnuel, string service, Agences agence)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateEmbauche = dateEmbauche;
            this.Fonction = fonction;
            this.SalaireAnnuel = salaireAnnuel;
            this.Service = service;
            this.Agence = agence;
        }

        public int Anciennete()
        {
            return (int) ((DateTime.Now - this.DateEmbauche).TotalDays/365);
        }

        public double PrimeAnnuelle()
        {
            return Math.Round(this.SalaireAnnuel * 0.05,2);
        }

        public double PrimeAnciennete()
        {
            return Math.Round(this.Anciennete()*this.SalaireAnnuel*0.02,2);
        }

        public double Prime()
        {
           return Math.Round(PrimeAnciennete() + PrimeAnnuelle());
        }

        public static int ComparerToNomPrenom(Employes E1, Employes E2)
        {
            if (E1.Nom == E2.Nom)
            {
                if (E1.Prenom.CompareTo(E2.Prenom) == 1)
                {
                    return 1;
                }
                else if (E1.Prenom.CompareTo(E2.Prenom) == -1)
                {
                    return -1;
                }
            }
            else if (E1.Nom.CompareTo(E2.Nom) == 1)
            {
                return 1;
            }
            else if (E1.Nom.CompareTo(E2.Nom) == -1)
            {
                return -1;
            }
            return 0;
        }

        public static int ComparerToService(Employes E1, Employes E2)
        {
            if (E1.Service == E2.Service)
            {
                return ComparerToNomPrenom(E1,E2);
            } else if (E1.Service.CompareTo(E2.Service) == 1)
            {
                return 1;
            }
            return -1;
        }


        public static double MasseSalariale(List<Employes> tab)
        {
            double masseSalariale = 0;
            foreach (Employes emp in tab)
            {
                masseSalariale += emp.SalaireAnnuel + emp.Prime();
            }
            return masseSalariale;
        }

        public bool ChequeVacances()
        {
            if (this.Anciennete() > 1 )
            {
                return true;
            }
            return false;
        }


        public override string ToString()
        {
            string aff = "";
            aff += "****************\n"
             + "Nom : " + this.Nom + "\n"
             + "Prenom : " + this.Prenom + "\n"
             + "Date d'embauche : " + this.DateEmbauche + "\n"
             + "Fonction : " + this.Fonction + "\n"
             + "Salaire Annuel : " + this.SalaireAnnuel + "\n"
             + "Service : " + this.Service + "\n"
             + "    Attaché à l'agence : \n"
             + this.Agence
             + "Chèque vacances : ";

            if (this.ChequeVacances())
            {
                aff += "Oui\n";
            } else
            {
                aff += "Non\n";
            }




            List<int> cheques = new List<int>();

            for (int i = 0; i < this.Enfants.Count; i++)
            {
                if (this.Enfants.Count != 0 && this.Enfants[i].ChequesNoel() != 0)
                    cheques.Add(this.Enfants[i].ChequesNoel());
            }

            int cheque20 = cheques.Count(x => x == 20);
            int cheque30 = cheques.Count(x => x == 30);
            int cheque50 = cheques.Count(x => x == 50);

            aff += "Chèques noel :";
            if (this.Enfants.Count == 0 ||(cheque20 == 0 && cheque30 == 0 && cheque50 == 0))
            {
                aff += " Non\n";
            }
            else
            {
                aff += " Oui\n";
            }

            if (cheque20 != 0)
                aff += "\n\t" + cheque20 + " chèque(s) noel de 20 euros";
            if (cheque30 != 0)
                aff += "\n\t" + cheque30 + " chèque(s) noel de 30 euros";
            if (cheque50 != 0)
                aff += "\n\t" + cheque50 + " chèque(s) noel de 50 euros";

            aff += "\n****************\n";
            return aff;
        }


    }
}
