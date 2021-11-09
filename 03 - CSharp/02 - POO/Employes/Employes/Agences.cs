using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employes
{
    class Agences
    {
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string ModeRestauration { get; set; }

        public Agences(string nom, string adresse, string codePostal, string ville, string modeResto)
        {
            this.Nom = nom;
            this.Adresse = adresse;
            this.CodePostal = codePostal;
            this.Ville = ville;
            this.ModeRestauration = modeResto;
        }

        public override string ToString()
        {
            return "    Nom : "+this.Nom+"\n"
                + "    Adresse :"+this.Adresse + "\n"
                + "    Code Postal :"+this.CodePostal + "\n"
                + "    Ville :"+this.Ville + "\n"
                + "    Mode de restauration :" + this.ModeRestauration + "\n";
        }
    }
}
