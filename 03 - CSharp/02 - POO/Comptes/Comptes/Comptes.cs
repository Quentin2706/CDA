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

        private double _solde;
        //public double Solde { get; }
        public int Code { get; }

        public Clients Proprietaire { get; set; }

        public double GetSolde()
        {
            return this._solde;
        }


        public Comptes(double soldeParam, Clients client)
        {
            _solde = Math.Round(soldeParam,2);
            this.Code = _codeIncremente++;
            this.Proprietaire = client;
        }

        public static int GetNbCompte()
        {
            return _codeIncremente-1;
        }


        public string Afficher()
        {
            return "*******************" 
                    + "\nNuméro de compte : " + this.Code
                    + "\nSolde du compte :" + Math.Round(this._solde,2) 
                    + this.Proprietaire.Afficher()
                    + "\n*******************";
        }


        public void Crediter(double somme)
        {
            this._solde += Math.Round(somme,2);
        }

        public void Crediter(double somme, Comptes compte)
        {
            this.Crediter(somme);
            compte.Debiter(somme);
        }

        public double Debiter(double montant)
        {
            return this._solde -= Math.Round(montant,2);
        }

        public void Debiter(double montant, Comptes compte)
        {
            compte.Crediter(montant);
            this.Debiter(montant);
        }

    }
}
