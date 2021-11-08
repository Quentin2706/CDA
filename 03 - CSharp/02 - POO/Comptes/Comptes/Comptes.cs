using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comptes
{
    class Comptes
    {
        private static int _codeIncremente = 1;

        private double solde;
        //public double Solde { get; }
        public int Code { get; }

        public Clients Proprietaire { get; set; }

        public double GetSolde()
        {
            return solde;
        }


        public Comptes(double soldeParam, Clients client)
        {
            solde = soldeParam;
            this.Code = _codeIncremente++;
            this.Proprietaire = client;
        }


            public static int GetCodeIncremente()
             {
            return _codeIncremente;
             }


        public string Afficher()
        {
            return "*******************" 
                    + "\nNuméro de compte : " + this.Code
                    + "\nSolde du compte :" + this.solde 
                    + this.Proprietaire.Afficher()
                    + "\n*******************";
        }

        public void Crediter(double somme)
        {
            solde += somme;
        }

        //public double Crediter(double montant, Comptes compte)
        //{
        //    return compte.Solde
        //}

    }
}
