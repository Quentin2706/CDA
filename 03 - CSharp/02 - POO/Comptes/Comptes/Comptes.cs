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
            _solde = soldeParam;
            this.Code = _codeIncremente++;
            this.Proprietaire = client;
        }


            public int GetCodeIncremente()
            {
                return _codeIncremente;
            }

        public staticint GetCodeIncremente()
        {
            return _codeIncremente;
        }


        public string Afficher()
        {
            return "*******************" 
                    + "\nNuméro de compte : " + this.Code
                    + "\nSolde du compte :" + this._solde 
                    + this.Proprietaire.Afficher()
                    + "\n*******************";
        }


        public void Crediter(double somme)
        {
            this._solde += somme;
        }

        public void Crediter(double somme, Comptes compte)
        {
            compte.Crediter(somme);
            this.Debiter(somme);
        }

        public double Debiter(double montant)
        {
            return this._solde -= montant;
        }

        public double Debiter(double montant, Comptes compte