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
        public double Prime { get; set; }

        public Employes(string nom, string prenom, DateTime dateEmbauche, string fonction, double salaireAnnuel, string service)
        {
            Nom = nom;
            Prenom = prenom;
            DateEmbauche = dateEmbauche;
            Fonction = fonction;
            SalaireAnnuel = salaireAnnuel;
            Service = service;
        }

        public int Anciennete()
        {
            DateTime aujd = DateTime.Now;
            TimeSpan diffResult = aujd - DateEmbauche;
            return (int) (diffResult.TotalDays/365);
        }

        public double PrimeAnnuelle()
        {
            double primeAnciennete = 0;

            for (int i = 0; i < this.Anciennete(); i++)
            {
                primeAnciennete += SalaireAnnuel * 0.02;
            }

            return Math.Round(primeAnciennete + (double) this.SalaireAnnuel * 0.05,2);
        }


    }
}
