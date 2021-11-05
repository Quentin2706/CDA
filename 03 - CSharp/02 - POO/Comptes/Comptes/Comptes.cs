using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comptes
{
    class Comptes
    {
        private static int _codeIncremente;
        public double Solde { get; }
        public int Code { get; }

        public Clients Proprietaire { get; set; }

        public Comptes(double solde, Clients client)
        {
            Solde = solde;
            _codeIncremente++;
            this.Code = _codeIncremente;
            this.Proprietaire = client;
        }

        public string Afficher()
        {
            return "\nNuméro de compte : " + this.Code
                    + "\nSolde du compte :" + this.Solde 
                    + this.Proprietaire.Afficher();
        }

    }
}
